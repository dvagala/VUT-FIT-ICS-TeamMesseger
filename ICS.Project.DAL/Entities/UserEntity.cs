using System;
using System.Collections.Generic;
using System.Text;
using ICS.Project.DAL.Entities.Base;

namespace ICS.Project.DAL.Entities
{
    public class UserEntity : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastActivity { get; set; }
        public EmailAdressEntity Email { get; set; }
        private string Password; //has to be kept in secure form

        public ICollection<TeamEntity> Teams { get; set; } = new List<TeamEntity>();
    }
}
