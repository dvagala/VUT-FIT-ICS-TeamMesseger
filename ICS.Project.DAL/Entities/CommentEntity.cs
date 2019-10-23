using System;
using System.ComponentModel.DataAnnotations.Schema;
using ICS.Project.DAL.Entities.Base;

namespace ICS.Project.DAL.Entities
{
    public class CommentEntity : MessageEntityBase
    {
        [ForeignKey("PostEntity")] public Guid? PostId { get; set; }

        public PostEntity Post { get; set; }
    }
}