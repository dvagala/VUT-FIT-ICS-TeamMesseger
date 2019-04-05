using System;
using System.Collections.Generic;
using System.Text;

namespace ICS.Project.DAL.Entities
{
    public class CommentEntity : EntityBase,IMessageEntity
    {
        public UserEntity Autor { get; set; }
        public string MessageText { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
