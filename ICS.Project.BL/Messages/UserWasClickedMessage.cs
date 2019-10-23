using ICS.Project.BL.Models;

namespace ICS.Project.BL.Messages
{
    public class UserWasClickedMessage : IMessage
    {
        public UserModel User { get; set; }
    }
}