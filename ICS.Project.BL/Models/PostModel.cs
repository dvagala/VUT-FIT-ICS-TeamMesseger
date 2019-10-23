using System;
using System.Collections.Generic;
using ICS.Project.BL.Models.Base;

namespace ICS.Project.BL.Models
{
    public class PostModel : MessageModelBase
    {
        public Guid? TeamId { get; set; }
        public TeamModel Team { get; set; }
        public string Title { get; set; }
        public IList<CommentModel> Comments { get; set; }
    }
}