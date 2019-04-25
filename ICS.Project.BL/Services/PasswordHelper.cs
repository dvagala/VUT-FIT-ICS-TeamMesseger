using System;
using System.Collections.Generic;
using System.Text;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using System.Windows;

namespace ICS.Project.BL.Services
{
    public class PasswordHelper
    {
        public UserModel AddEncryptedPasswordToUserModel(string plainTextPassword)
        {
            UserModel user = new UserModel
            {
                Salt = new byte[0],
                Hash = new byte[0],
                Iterations = 10000

            };
            return user;
        }

        public bool IsPasswordCorrect(string plainTextPassword, byte[] salt, byte[] hash, int iterations)
        {
            return true;
        }
    }
}
