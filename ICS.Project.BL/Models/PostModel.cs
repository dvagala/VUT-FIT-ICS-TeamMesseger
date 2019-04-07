using System.Collections.Generic;
using ICS.Project.BL.Models.Base;

namespace ICS.Project.BL.Models
{
    public class PostModel : MessageModelBase
    {
        public string Title { get; set; }

        public ICollection<CommentModel> Comments { get; set; } = new List<CommentModel>();
    }
}