using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using ICS.Project.BL.Models;
using System.Security.Cryptography;

namespace ICS.Project.BL.Services
{
    public class PasswordHelper
    {
        byte[] GenerateSalt()
        {
            var bytes = new byte[32];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(bytes);
            }
            return bytes;
        }

        public byte[] HashPassword(SecureString secureStringPassword, byte[] salt, int iterations)
        {
            IntPtr bstr = IntPtr.Zero;
            byte[] workArray = null;
            GCHandle handle = GCHandle.Alloc(workArray, GCHandleType.Pinned);
            try
            {
                /*** PLAINTEXT EXPOSURE BEGINS HERE ***/
                bstr = Marshal.SecureStringToBSTR(secureStringPassword);
                unsafe
                {
                    byte* bstrBytes = (byte*)bstr;
                    workArray = new byte[secureStringPassword.Length * 2];

                    for (int i = 0; i < workArray.Length; i++)
                        workArray[i] = *bstrBytes++;
                }
                using (var deriveBytes = new Rfc2898DeriveBytes(workArray, salt, iterations))
                {
                    return deriveBytes.GetBytes(16);
                }
            }
            finally
            {
                if (workArray != null)
                    for (int i = 0; i < workArray.Length; i++)
                        workArray[i] = 0;
                handle.Free();
                if (bstr != IntPtr.Zero)
                    Marshal.ZeroFreeBSTR(bstr);
                /*** PLAINTEXT EXPOSURE ENDS HERE ***/
            }
        }

        public void AddEncryptedPasswordToUserModel(UserModel user, SecureString secureStringPassword)
        {
            byte[] salting = GenerateSalt();
            int iterCount = 10000 + secureStringPassword.Length;

            user.Salt = salting;
            user.IterationCount = iterCount;
            user.PasswordHash = HashPassword(secureStringPassword, salting, iterCount);
        }

        public bool IsPasswordCorrect(UserModel user, SecureString secureStringPassword)
        {
            byte[] usedPassword = HashPassword(secureStringPassword, user.Salt, user.IterationCount);
            if (usedPassword.SequenceEqual(user.PasswordHash))
            {
                return true;
            }
            return false;
        }
    }
}
