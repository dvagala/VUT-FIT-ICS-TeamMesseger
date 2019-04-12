using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ICS.Project.DAL.Entities.Base
{
    public abstract class MessageEntityBase : EntityBase, IMessageEntity
    {
        [ForeignKey("UserEntity")] public Guid? AutorId { get; set; }

        public UserEntity Autor { get; set; }

        public string MessageText { get; set; }
        public DateTime PublishDate { get; set; }
    }
}