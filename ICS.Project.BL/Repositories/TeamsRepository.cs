﻿using System;
using System.Collections.Generic;
using System.Linq;
using ICS.Project.BL.Mappers;
using ICS.Project.BL.Models;
using ICS.Project.DAL;
using ICS.Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ICS.Project.BL.Repositories
{
    public class TeamsRepository : ITeamsRepository
    {
        private readonly IDbContextFactory dbContextFactory;

        public TeamsRepository(IDbContextFactory dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public IEnumerable<PostModel> GetPostsWithCommentsAndAuthors(Guid teamId)
        {
            var posts = dbContextFactory.CreateDbContext()
                .Posts
                .Include(s => s.Author)
                .Include(s => s.Comments)
                .ThenInclude(s => s.Author)
                .Where(s => s.TeamId == teamId)
                .Select(s => Mapper.MapPostModelFromEntityWithCommentsAndAuthor(s));

            return posts;
        }

        public IEnumerable<PostModel> GetPostsWithComments(Guid teamId)
        {
            var posts = dbContextFactory.CreateDbContext()
                .Posts
                .Include(s => s.Comments)
                .Where(s => s.TeamId == teamId)
                .Select(s => Mapper.MapPostModelFromEntityWithComments(s)).ToList();

            return posts;
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
        public IEnumerable<UserModel> GetTeamMembers(Guid teamId)
        {
            var members = dbContextFactory.CreateDbContext()
                .UserInTeam
                .Where(s => s.TeamId == teamId)
                .Include(s => s.User)
                .Select(s => Mapper.MapUserModelFromEntity(s.User));

            return members;
        }

        public void AddUserToTeam(Guid userId, Guid teamId)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = new UserInTeamEntity
                {
                    UserId = userId,
                    TeamId = teamId
                };

                dbContext.UserInTeam.Add(entity);
                dbContext.SaveChanges();
            }
        }

        public void RemoveUserFromTeam(Guid userId, Guid teamId)
        {
            var userInTeamId = dbContextFactory.CreateDbContext()
                .UserInTeam
                .Where(s => s.TeamId == teamId && s.UserId == userId)
                .Select(s => s.ID)
                .FirstOrDefault();

            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var userInTeamEntity = new UserInTeamEntity
                {
                    ID = userInTeamId
                };
                dbContext.UserInTeam.Attach(userInTeamEntity);
                dbContext.UserInTeam.Remove(userInTeamEntity);
                dbContext.SaveChanges();
            }
        }

        public IList<TeamModel> GetAll()
        {
            return dbContextFactory.CreateDbContext()
                .Teams
                .Select(Mapper.MapTeamModelFromEntity).ToList();
        }


        public TeamModel GetFirst()
        {
            var foundEntity = dbContextFactory
                .CreateDbContext()
                .Teams
                .FirstOrDefault();
            return foundEntity == null ? null : Mapper.MapTeamModelFromEntity(foundEntity);
        }


        public TeamModel GetById(Guid id)
        {
            var foundEntity = dbContextFactory
                .CreateDbContext()
                .Teams
                .FirstOrDefault(t => t.ID == id);
            return foundEntity == null ? null : Mapper.MapTeamModelFromEntity(foundEntity);
        }

        public void Update(TeamModel post)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = Mapper.MapTeamModelToEntity(post);
                dbContext.Teams.Update(entity);
                dbContext.SaveChanges();
            }
        }

        public TeamModel Add(TeamModel post)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = Mapper.MapTeamModelToEntity(post);
                dbContext.Teams.Add(entity);
                dbContext.SaveChanges();
                return Mapper.MapTeamModelFromEntity(entity);
            }
        }
        public void RemoveWithAllPostsAndComments(Guid id)
        {
            foreach (var post in GetPostsWithComments(id))
            {                
                foreach (var comment in post.Comments)
                {
                    using (var dbContext = dbContextFactory.CreateDbContext())
                    {
                        var commentEntity = new CommentEntity
                        {
                            ID = comment.ID
                        };
                        dbContext.Comments.Attach(commentEntity);
                        dbContext.Comments.Remove(commentEntity);
                        dbContext.SaveChanges();
                    }
                }
                using (var dbContext = dbContextFactory.CreateDbContext())
                {
                    var postEntity = new PostEntity()
                    {
                        ID = post.ID
                    };
                    dbContext.Posts.Attach(postEntity);
                    dbContext.Posts.Remove(postEntity);
                    dbContext.SaveChanges();
                }
            }

            foreach (var member in GetTeamMembers(id))
            {
                RemoveUserFromTeam(member.ID, id);
            }
            Remove(id);
        }

        public void Remove(Guid id)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var team = new TeamEntity
                {
                    ID = id
                };
                dbContext.Teams.Attach(team);
                dbContext.Teams.Remove(team);
                dbContext.SaveChanges();
            }
        }
    }
}