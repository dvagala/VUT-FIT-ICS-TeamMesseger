using System;
using System.Collections.Generic;
using System.Text;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Repositories
{
    public interface ICommentRepository
    {
        IEnumerable<CommentModel> GetAll();
        CommentModel GetById(Guid id);
        void Update(CommentModel post);
        CommentModel Add(CommentModel post);
        void Remove(Guid id);
    }
}
