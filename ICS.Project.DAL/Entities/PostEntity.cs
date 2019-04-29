using System;
using System.ComponentModel.DataAnnotations.Schema;
using ICS.Project.DAL.Entities.Base;

namespace ICS.Project.DAL.Entities
{
    public class PostEntity : MessageEntityBase
    {
        [ForeignKey("TeamEntity")] public Guid? TeamId { get; set; }

        public TeamEntity Team { get; set; }

        public string Title { get; set; }
    }
}