using System;
using System.Collections.Generic;
using ICS.Project.BL.Models.Base;

namespace ICS.Project.BL.Models
{
    public class UserModel : ModelBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime LastActivity { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } //has to be kept in secure form

        public ICollection<TeamModel> Teams { get; set; } = new List<TeamModel>();
    }
}