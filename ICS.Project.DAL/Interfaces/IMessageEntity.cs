using System;

namespace ICS.Project.DAL.Entities
{
    public interface IMessageEntity
    {
        UserEntity Autor { get; }
        string MessageText { get; }
        TimeSpan PublishDate { get; }
    }
}