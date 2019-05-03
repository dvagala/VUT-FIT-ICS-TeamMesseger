using System;
using System.Collections.Generic;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Repositories
{
    public interface ICommentsRepository
    {
        IEnumerable<CommentModel> GetAll();
        CommentModel GetById(Guid id);
        void Update(CommentModel comment);
        CommentModel Add(CommentModel comment);
        void Remove(Guid id);
    }
}