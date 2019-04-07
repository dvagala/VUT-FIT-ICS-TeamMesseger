using System.Collections.Generic;
using ICS.Project.DAL.Entities.Base;

namespace ICS.Project.DAL.Entities
{
    public class TeamEntity : EntityBase
    {
        public string Name { get; set; }

        public string Description { get; set; }

        //public ICollection<UserEntity>C:\Users\glos\Documents\ICS zh\ICS.Project.DAL\Entities\TeamEntity.cs Users { get; set; } = new List<UserEntity>(); TODO Pokial tu je tento vztah 
        public ICollection<PostEntity> Posts { get; set; } = new List<PostEntity>();
    }
}