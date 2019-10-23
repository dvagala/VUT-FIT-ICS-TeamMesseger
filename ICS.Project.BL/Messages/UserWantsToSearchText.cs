namespace ICS.Project.BL.Messages
{
    public class UserWantsToSearchText : IMessage
    {
        public string SearchedText { get; set; }
    }
}