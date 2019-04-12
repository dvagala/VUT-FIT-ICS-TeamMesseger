using System;

namespace ICS.Project.BL.Models.Base
{
    public interface IMessageModelBase
    {
        Guid? AutorId { get; }
        UserModel Autor { get; }
        string MessageText { get; }
        DateTime PublishDate { get; }
    }
}