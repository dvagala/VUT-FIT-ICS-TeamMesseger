using System;
using System.Collections.Generic;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Repositories
{
    public interface IPostsRepository
    {
        UserModel GetAuthorOfPost(Guid id);
        IEnumerable<PostModel> GetAll();
        PostModel GetById(Guid id);

        PostModel GetByIdWithAuthor(Guid id);
        IList<CommentModel> GetCommentsWithAuthors(Guid id);


        IList<CommentModel> GetComments(Guid id);

        void Update(PostModel post);
        PostModel Add(PostModel post);
        void Remove(Guid id);
    }
}