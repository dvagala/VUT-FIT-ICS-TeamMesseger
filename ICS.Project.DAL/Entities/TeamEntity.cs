using ICS.Project.DAL.Entities.Base;

namespace ICS.Project.DAL.Entities
{
    public class TeamEntity : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}