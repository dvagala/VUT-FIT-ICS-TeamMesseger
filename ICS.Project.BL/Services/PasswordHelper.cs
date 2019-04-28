using System.Linq;
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
        byte[] hashPassword(byte[] password, byte[] salt, int iterations)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                return deriveBytes.GetBytes(16);
            }
        }


        public void AddEncryptedPasswordToUserModel(UserModel user, string plainTextPassword)
        {
            byte[] bytePassword = Encoding.ASCII.GetBytes(plainTextPassword);
            byte[] salting = GenerateSalt();
            int iterCount = 10000 + plainTextPassword.Length;

            user.Salt = salting;
            user.IterationCount = iterCount;
            user.PasswordHash = hashPassword(bytePassword, salting, iterCount);
        }

        public bool IsPasswordCorrect(string plainTextPassword, UserModel user)
        {
            byte[] bytePassword = Encoding.ASCII.GetBytes(plainTextPassword);
            byte[] usedPassword = hashPassword(bytePassword, user.Salt, user.IterationCount);
            if (usedPassword.SequenceEqual(user.PasswordHash))
            {
                return true;
            }
            return false;
        }
    }
}
