using System;
using System.Collections.Generic;
using System.Linq;
using ICS.Project.BL.Mappers;
using ICS.Project.BL.Models;
using ICS.Project.DAL;
using ICS.Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ICS.Project.BL.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly IDbContextFactory dbContextFactory;

        public UsersRepository(IDbContextFactory dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public IEnumerable<TeamModel> GetUserTeams(Guid userId)
        {
            var t = dbContextFactory.CreateDbContext()
                .UserInTeam
                .Where(s => s.UserId == userId)
                .Include(s => s.Team)
                .Select(s => Mapper.MapTeamModelFromEntity(s.Team));

            return t;
        }

        public IEnumerable<UserModel> GetAll()
        {
            return dbContextFactory.CreateDbContext()
                .Users
                .Select(Mapper.MapUserModelFromEntity);
        }

        public UserModel GetById(Guid id)
        {
            var foundEntity = dbContextFactory
                .CreateDbContext()
                .Users
                .FirstOrDefault(t => t.ID == id);

            return foundEntity == null ? null : Mapper.MapUserModelFromEntity(foundEntity);
        }

        public void Update(UserModel user)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = Mapper.MapUserModelToEntity(user);
                dbContext.Users.Update(entity);
                dbContext.SaveChanges();
            }
        }

        public UserModel Add(UserModel user)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = Mapper.MapUserModelToEntity(user);
                dbContext.Users.Add(entity);
                dbContext.SaveChanges();
                return Mapper.MapUserModelFromEntity(entity);
            }
        }

        public void Remove(Guid id)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
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