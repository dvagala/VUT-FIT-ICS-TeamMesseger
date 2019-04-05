using System;
using System.Collections.Generic;
using System.Text;

namespace ICS.Project.DAL.Entities
{
    public class UserEntity : EntityBase
    {
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime LastActivity { get; set; }
        public EmailAdressEntity Email { get; set; }
        private string Password; //has to be kept in secure form

        public ICollection<TeamEntity> Teams { get; set; } = new List<TeamEntity>();
    }
}
