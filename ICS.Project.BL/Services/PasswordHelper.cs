using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Services
{
    public class PasswordHelper
    {
        private byte[] GenerateSalt()
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
            var bstr = IntPtr.Zero;
            byte[] workArray = null;
            var handle = GCHandle.Alloc(workArray, GCHandleType.Pinned);
            try
            {
                /*** PLAINTEXT EXPOSURE BEGINS HERE ***/
                bstr = Marshal.SecureStringToBSTR(secureStringPassword);
                unsafe
                {
                    var bstrBytes = (byte*) bstr;
                    workArray = new byte[secureStringPassword.Length * 2];

                    for (var i = 0; i < workArray.Length; i++)
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
                    for (var i = 0; i < workArray.Length; i++)
                        workArray[i] = 0;
                handle.Free();
                if (bstr != IntPtr.Zero)
                    Marshal.ZeroFreeBSTR(bstr);
                /*** PLAINTEXT EXPOSURE ENDS HERE ***/
            }
        }

        public void AddEncryptedPasswordToUserModel(UserModel user, SecureString secureStringPassword)
        {
            var salting = GenerateSalt();
            var iterCount = 10000 + secureStringPassword.Length;

            user.Salt = salting;
            user.IterationCount = iterCount;
            user.PasswordHash = HashPassword(secureStringPassword, salting, iterCount);
        }

        public bool IsPasswordCorrect(UserModel user, SecureString secureStringPassword)
        {
            var usedPassword = HashPassword(secureStringPassword, user.Salt, user.IterationCount);
            if (usedPassword.SequenceEqual(user.PasswordHash)) return true;
            return false;
        }
    }
}