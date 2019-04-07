using System.Collections.Generic;
using ICS.Project.BL.Models.Base;

namespace ICS.Project.BL.Models
{
    public class TeamModel : ModelBase
    {
        public string Name { get; set; }
        public string Description { get; set; }

        //public ICollection<UseModel> Users { get; set; } = new List<UseModel>(); TODO Pokial tu je tento vztah 
        public ICollection<PostModel> Posts { get; set; } = new List<PostModel>();
    }
}