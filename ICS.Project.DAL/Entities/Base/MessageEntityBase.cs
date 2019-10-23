using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ICS.Project.DAL.Entities.Base
{
    public abstract class MessageEntityBase : EntityBase, IMessageEntity
    {
        [ForeignKey("UserEntity")] public Guid? AuthorId { get; set; }

        public UserEntity Author { get; set; }

        public string MessageText { get; set; }
        public DateTime PublishDate { get; set; }
    }
}