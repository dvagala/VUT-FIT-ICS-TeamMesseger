using System;

namespace ICS.Project.DAL.Entities.Base
{
    public abstract class MessageEntityBase : EntityBase, IMessageEntity
    {
        public UserEntity Autor { get; set; }
        public string MessageText { get; set; }
        public DateTime PublishDate { get; set; }
    }
}