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
    public class TeamsRepository : ITeamsRepository
    {
        private readonly IDbContextFactory dbContextFactory;
        private readonly IMapper mapper;

        public TeamsRepository(IDbContextFactory dbContextFactory, IMapper mapper)
        {
            this.dbContextFactory = dbContextFactory;
            this.mapper = mapper;
        }

        public IEnumerable<TeamModel> GetAll()
        {
            return dbContextFactory.CreateDbContext()
                .Teams
                .Select(mapper.MapTeamModelFromEntity);
        }

        public TeamModel GetById(Guid id)
        {
            var foundEntity = dbContextFactory
                .CreateDbContext()
                .Teams
                .FirstOrDefault(t => t.ID == id);
            return foundEntity == null ? null : mapper.MapTeamModelFromEntity(foundEntity);
        }

        public void Update(TeamModel post)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = mapper.MapTeamModelToEntity(post);
                dbContext.Teams.Update(entity);
                dbContext.SaveChanges();
            }
        }

        public TeamModel Add(TeamModel post)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = mapper.MapTeamModelToEntity(post);
                dbContext.Teams.Add(entity);
                dbContext.SaveChanges();
                return mapper.MapTeamModelFromEntity(entity);
            }
        }

        public void Remove(Guid id)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var post = new TeamEntity
                {
                    ID = id
                };
                dbContext.Teams.Attach(post);
                dbContext.Teams.Remove(post);
                dbContext.SaveChanges();
            }
        }
    }
}
