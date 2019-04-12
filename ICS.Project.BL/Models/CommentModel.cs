using System;
using ICS.Project.BL.Models.Base;

namespace ICS.Project.BL.Models
{
    public class CommentModel : MessageModelBase
    {
        public Guid? PostId { get; set; }
    }
}