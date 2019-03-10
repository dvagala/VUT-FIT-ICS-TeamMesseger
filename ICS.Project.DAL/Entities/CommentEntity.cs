using System;
using System.Collections.Generic;
using System.Text;

namespace ICS.Project.DAL.Entities
{
    public class CommentEntity : IMessageEntity
    {
        public UserEntity Autor { get; set; }
        public string MessageText { get; set; }
        public TimeSpan PublishDate { get; set; }
    }
}
