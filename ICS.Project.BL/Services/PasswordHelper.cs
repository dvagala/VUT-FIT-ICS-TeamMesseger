using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using System.Windows;
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


        public UserModel AddEncryptedPasswordToUserModel(string plainTextPassword)
        {
            byte[] bytePassword = Encoding.ASCII.GetBytes(plainTextPassword);
            byte[] salting = GenerateSalt();
            int iterCount = 10000 + plainTextPassword.Length;

            UserModel user = new UserModel
            {

                Salt = salting,
                IterationCount = iterCount,
                Password = hashPassword(bytePassword,salting,iterCount)

            };
            return user;
        }

        public bool IsPasswordCorrect(string plainTextPassword, UserModel user)
        {
            byte[] bytePassword = Encoding.ASCII.GetBytes(plainTextPassword);
            byte[] usedPassword = hashPassword(bytePassword, user.Salt, user.IterationCount);
            if (usedPassword.SequenceEqual(user.Password))
            {
                return true;
            }
            return false;
        }
    }
}
