using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICS.Project.DAL.Entities.Base;

namespace ICS.Project.DAL.Entities
{
    public class UserEntity : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime LastActivity { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } //has to be kept in secure form

        public ICollection<TeamEntity> Teams { get; set; } = new List<TeamEntity>();

        public string MessageText { get; set; }
    }

}
