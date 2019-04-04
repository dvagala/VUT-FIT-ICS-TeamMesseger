using System;
using System.Collections.Generic;

namespace ICS.Project.DAL.Entities
{
    public class TeamEntity : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        //public ICollection<UserEntity> Users { get; set; } = new List<UserEntity>(); TODO Pokial tu je tento vztah 
        public ICollection<PostEntity> Posts { get; set; } = new List<PostEntity>();
    }
}