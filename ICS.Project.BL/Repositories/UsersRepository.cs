using System;
using System.Collections.Generic;
using System.Linq;
using ICS.Project.BL.Mappers;
using ICS.Project.BL.Models;
using ICS.Project.DAL;
using ICS.Project.DAL.Entities;

namespace ICS.Project.BL.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly IDbContextFactory _dbContextFactory;

        public UsersRepository(IDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public UserModel GetByEmail(string email)
        {
            var user = _dbContextFactory
                .CreateDbContext()
                .Users
                .FirstOrDefault(t => t.Email == email);

            return user == null ? null : Mapper.MapUserModelFromEntity(user);
            ;
        }

        public IList<UserModel> GetAll()
        {
            return _dbContextFactory.CreateDbContext()
                .Users
                .Select(Mapper.MapUserModelFromEntity).ToList();
        }

        public UserModel GetById(Guid id)
        {
            var foundEntity = _dbContextFactory
                .CreateDbContext()
                .Users
                .FirstOrDefault(t => t.ID == id);

            return foundEntity == null ? null : Mapper.MapUserModelFromEntity(foundEntity);
        }

        public UserModel GetFirst()
        {
            var foundEntity = _dbContextFactory
                .CreateDbContext()
                .Users
                .FirstOrDefault();
            return foundEntity == null ? null : Mapper.MapUserModelFromEntity(foundEntity);
        }

        public void Update(UserModel user)
        {
            using (var dbContext = _dbContextFactory.CreateDbContext())
            {
                var entity = Mapper.MapUserModelToEntity(user);
                dbContext.Users.Update(entity);
                dbContext.SaveChanges();
            }
        }

        public UserModel Add(UserModel user)
        {
            using (var dbContext = _dbContextFactory.CreateDbContext())
            {
                var entity = Mapper.MapUserModelToEntity(user);
                dbContext.Users.Add(entity);
                dbContext.SaveChanges();
                return Mapper.MapUserModelFromEntity(entity);
            }
        }

        public void Remove(Guid id)
        {
            using (var dbContext = _dbContextFactory.CreateDbContext())
            {
                var user = new UserEntity
                {
                    ID = id
                };
                dbContext.Users.Attach(user);
                dbContext.Users.Remove(user);
                dbContext.SaveChanges();
            }
        }
    }
}