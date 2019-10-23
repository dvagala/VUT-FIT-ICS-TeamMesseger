using System;

namespace ICS.Project.BL.Models.Base
{
    public interface IMessageModelBase
    {
        Guid? AuthorId { get; }
        UserModel Author { get; }
        string MessageText { get; }
        DateTime PublishDate { get; }
    }
}