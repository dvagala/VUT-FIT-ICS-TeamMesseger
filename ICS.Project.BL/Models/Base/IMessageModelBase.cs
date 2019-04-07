using System;

namespace ICS.Project.BL.Models.Base
{
    public interface IMessageModelBase
    {
        UserModel Autor { get; }
        string MessageText { get; }
        DateTime PublishDate { get; }
    }
}