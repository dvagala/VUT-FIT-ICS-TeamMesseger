using System;
using ICS.Project.BL.Models.Base;

namespace ICS.Project.BL.Models
{
    public class UserModel : ModelBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime LastActivity { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public byte[] Salt { get; set; }
        public int IterationCount { get; set; }
    }
}