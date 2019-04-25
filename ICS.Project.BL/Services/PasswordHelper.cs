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
                Password = new byte[0],
                IterationCount = 10000

            };
            return user;
        }

        public bool IsPasswordCorrect(string plainTextPassword, byte[] password, byte[] hash, int iterationCount)
        {
            return true;
        }
    }
}
