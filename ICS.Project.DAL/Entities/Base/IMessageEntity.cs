using System;

namespace ICS.Project.DAL.Entities.Base
{
    public interface IMessageEntity
    {
        UserEntity Author { get; }
        string MessageText { get; }
        DateTime PublishDate { get; }
    }
}