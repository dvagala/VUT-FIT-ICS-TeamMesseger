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
    public class PostsRepository : IPostsRepository
    {
        private readonly IDbContextFactory dbContextFactory;

        public PostsRepository(IDbContextFactory dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public UserModel GetAuthorOfPost(Guid id)
        {
            var postEntityWithAuthor = dbContextFactory
                .CreateDbContext()
                .Posts
                .Where(s => s.ID == id)
                .Include(s => s.Author)
                .Select(s => s.Author)
                .FirstOrDefault();

            return Mapper.MapUserModelFromEntity(postEntityWithAuthor);
        }

        public IEnumerable<PostModel> GetAll()
        {
            return dbContextFactory.CreateDbContext()
                .Posts
                .Select(Mapper.MapPostModelFromEntity);
        }

        public PostModel GetById(Guid id)
        {
            var foundEntity = dbContextFactory
                .CreateDbContext()
                .Posts
                .FirstOrDefault(t => t.ID == id);
            return foundEntity == null ? null : Mapper.MapPostModelFromEntity(foundEntity);
        }

        public void Update(PostModel post)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = Mapper.MapPostModelToEntity(post);
                dbContext.Posts.Update(entity);
                dbContext.SaveChanges();
            }
        }

        public PostModel Add(PostModel post)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = Mapper.MapPostModelToEntity(post);
                dbContext.Posts.Add(entity);
                dbContext.SaveChanges();
                return Mapper.MapPostModelFromEntity(entity);
            }
        }

        public void Remove(Guid id)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var post = new PostEntity
                {
                    ID = id
                };
                dbContext.Posts.Attach(post);
                dbContext.Posts.Remove(post);
                dbContext.SaveChanges();
            }
        }
    }
}