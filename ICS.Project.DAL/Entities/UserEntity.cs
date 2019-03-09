using System;
using System.Collections.Generic;
using System.Text;

namespace ICS.Project.DAL.Entities
{
    public class UserEntity : EntityBase
    {
        public string UserName;
        public EmailAdressEntity Email { get; set; }
        private string Password; //TODO: has to be kept in secure form

        public ICollection<TeamEntity> Teams { get; set; } = new List<TeamEntity>();
    }
}
