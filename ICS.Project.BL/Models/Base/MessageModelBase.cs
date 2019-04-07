using System;

namespace ICS.Project.BL.Models.Base
{
    public class MessageModelBase : ModelBase, IMessageModelBase
    {
        public UserModel Autor { get; set; }
        public string MessageText { get; set; }
        public DateTime PublishDate { get; set; }
    }
}