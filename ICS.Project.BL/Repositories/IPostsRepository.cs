using System;
using System.Collections.Generic;
using System.Text;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Repositories
{
    public interface IPostsRepository
    {
        IEnumerable<PostModel> GetAll();
        PostModel GetById(int id);
        void Update(PostModel post);
        PostModel Add(PostModel post);
        void Remove(Guid id);
    }
}
