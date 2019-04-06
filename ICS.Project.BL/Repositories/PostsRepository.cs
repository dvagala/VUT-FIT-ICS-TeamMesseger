using System;
using System.Collections.Generic;
using System.Text;
using ICS.Project.BL.Models;
using ICS.Project.BL.Mapper;
using ICS.Project.DAL;
using ICS.Project.DAL.Entities;

namespace ICS.Project.BL.Repositories
{
    class PostsRepository : IPostsRepository
    {
        private readonly IDbContextFactory dbContextFactory;
        private readonly IMapper mapper;
        public PostsRepository(IDbContextFactory dbContextFactory, IMapper mapper)
        {
            this.dbContextFactory = dbContextFactory;
            this.mapper = mapper;
        }

        public IEnumerable<PostModel> GetAll()
        {
            //return dbContextFactory.CreateDbContext()
            //    .Posts
            //    .Select(mapper.MapPostModelFromEntity);
            return null;
        }

        public PostModel GetById(int id)
        {
            //var foundEntity = dbContextFactory
            //    .CreateDbContext()
            //    .Posts
            //    .Include(t => t.AssignedPerson)
            //    .FirstOrDefault(t => t.Id == id);
            //return foundEntity == null ? null : mapper.MapPostModelFromEntity(foundEntity);
            return null;
        }

        public void Update(PostModel post)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = mapper.MapPostModelToEntity(post);
                dbContext.Posts.Update(entity);
                dbContext.SaveChanges();
            }
        }

        public PostModel Add(PostModel post)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = mapper.MapPostModelToEntity(post);
                dbContext.Posts.Add(entity);
                dbContext.SaveChanges();
                return mapper.MapPostModelFromEntity(entity);
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
