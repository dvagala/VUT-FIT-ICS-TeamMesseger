using System;
using ICS.Project.BL.Models.Base;

namespace ICS.Project.BL.Models
{
    public class UserModel : ModelBase
    {
        private string _name;
        private string _surname;
        private string _email;

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

        public DateTime LastActivity { get; set; }

        public string Email
        {
            get => _email;
            set => _email = value?.Trim();
        }

        public byte[] PasswordHash { get; set; }
        public byte[] Salt { get; set; }
        public int IterationCount { get; set; }
    }
}