using System;
using System.Collections.Generic;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Repositories
{
    public interface ICommentsRepository
    {
        IEnumerable<CommentModel> GetAll();
        CommentModel GetById(Guid id);
        void Update(CommentModel post);
        CommentModel Add(CommentModel post);
        void Remove(Guid id);
    }
}