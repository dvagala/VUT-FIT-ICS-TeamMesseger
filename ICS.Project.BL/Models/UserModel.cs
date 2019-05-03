using System;
using ICS.Project.BL.Models.Base;

namespace ICS.Project.BL.Models
{
    public class UserModel : ModelBase
    {
        private string _email;
        private string _name;

        private string _surname;

        public string Name
        {
            get => _name;
            set => _name = value?.Trim();
        }

        public string Surname
        {
            get => _surname;
            set => _surname = value?.Trim();
        }

        public string Email
        {
            get => _email;
            set => _email = value?.Trim();
        }

        public string FullName => $"{_name} {_surname}";
        public byte[] PasswordHash { get; set; }
        public byte[] Salt { get; set; }
        public int IterationCount { get; set; }
        public DateTime LastLogoutTime { get; set; }
        public bool IsLoggedIn { get; set; }
    }
}