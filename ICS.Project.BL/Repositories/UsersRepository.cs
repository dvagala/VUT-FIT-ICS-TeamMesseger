using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Linq;
using ICS.Project.BL.Models;
using ICS.Project.BL.Mapper;
using ICS.Project.DAL;
using ICS.Project.DAL.Entities;

namespace ICS.Project.BL.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly IDbContextFactory dbContextFactory;
        private readonly IMapper mapper;

        public UsersRepository(IDbContextFactory dbContextFactory, IMapper mapper)
        {
            this.dbContextFactory = dbContextFactory;
            this.mapper = mapper;
        }

        public IEnumerable<UserModel> GetAll()
        {
            return dbContextFactory.CreateDbContext()
                .Users
                .Select(mapper.MapUserModelFromEntity);
        }

        public UserModel GetById(Guid id)
        {
            var foundEntity = dbContextFactory
                .CreateDbContext()
                .Users
                .FirstOrDefault(t => t.ID == id);
            return foundEntity == null ? null : mapper.MapUserModelFromEntity(foundEntity);
        }

        public void Update(UserModel post)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = mapper.MapUserModelToEntity(post);
                dbContext.Users.Update(entity);
                dbContext.SaveChanges();
            }
        }

        public UserModel Add(UserModel post)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = mapper.MapUserModelToEntity(post);
                dbContext.Users.Add(entity);
                dbContext.SaveChanges();
                return mapper.MapUserModelFromEntity(entity);
            }
        }

        public void Remove(Guid id)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var post = new UserEntity
                {
                    ID = id
                };
                dbContext.Users.Attach(post);
                dbContext.Users.Remove(post);
                dbContext.SaveChanges();
            }
        }
    }
}
