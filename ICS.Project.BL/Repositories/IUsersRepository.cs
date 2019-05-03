using System;
using System.Collections.Generic;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Repositories
{
    public interface IUsersRepository
    {
        UserModel GetByEmail(string email);

        IList<UserModel> GetAll();
        UserModel GetById(Guid id);
        void Update(UserModel post);
        UserModel Add(UserModel post);
        void Remove(Guid id);
    }
}