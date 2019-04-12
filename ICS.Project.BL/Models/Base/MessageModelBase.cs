using System;

namespace ICS.Project.BL.Models.Base
{
    public class MessageModelBase : ModelBase, IMessageModelBase
    {
        public Guid? AuthorId { get; set; }
        public UserModel Author { get; set; }
        public string MessageText { get; set; }
        public DateTime PublishDate { get; set; }
    }
}