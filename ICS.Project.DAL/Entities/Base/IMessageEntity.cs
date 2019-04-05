using System;

namespace ICS.Project.DAL.Entities.Base
{
    public interface IMessageEntity
    {
        UserEntity Autor { get; }
        string MessageText { get; }
        DateTime PublishDate { get; }
    }
}