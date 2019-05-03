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
        UserModel GetFirst();
        void Update(UserModel user);
        UserModel Add(UserModel user);
        void Remove(Guid id);
    }
}