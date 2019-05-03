using ICS.Project.BL.Models;

namespace ICS.Project.BL.Messages
{
    public class UserLoggedMessage : IMessage
    {
        public UserModel User { get; set; }
    }
}