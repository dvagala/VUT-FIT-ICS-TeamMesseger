using System;
using System.Collections.Generic;
using System.Text;
using ICS.Project.DAL.Entities.Base;

namespace ICS.Project.DAL.Entities
{
    public class PostEntity : MessageEntityBase
    {
        public string Title { get; set; }

        public ICollection<CommentEntity> Comments { get; set; } = new List<CommentEntity>();
    }
}
