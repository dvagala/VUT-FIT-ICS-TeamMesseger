using System;
using System.Collections.Generic;
using System.Text;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<UserModel> GetAll();
        UserModel GetById(Guid id);
        void Update(UserModel post);
        UserModel Add(UserModel post);
        void Remove(Guid id);
    }
}
