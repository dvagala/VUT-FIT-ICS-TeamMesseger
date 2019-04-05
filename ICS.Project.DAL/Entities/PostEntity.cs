using System;
using System.Collections.Generic;
using System.Text;

namespace ICS.Project.DAL.Entities
{
    public class PostEntity : EntityBase, IMessageEntity
    {
        public UserEntity Autor { get; set; }
        public DateTime PublishDate { get; set; }
        public string MessageText { get; set; }

        public string Title { get; set; }

        public ICollection<CommentEntity> Comments = new List<CommentEntity>();
    }
}
