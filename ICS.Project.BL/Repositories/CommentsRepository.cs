using System;
using System.Collections.Generic;
using System.Linq;
using ICS.Project.BL.Mappers;
using ICS.Project.BL.Models;
using ICS.Project.DAL;
using ICS.Project.DAL.Entities;

namespace ICS.Project.BL.Repositories
{
    public class CommentsRepository : ICommentsRepository
    {
        private readonly IDbContextFactory dbContextFactory;

        public CommentsRepository(IDbContextFactory dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        public IEnumerable<CommentModel> GetAll()
        {
            return dbContextFactory.CreateDbContext()
                .Comments
                .Select(Mapper.MapCommentModelFromEntity);
        }

        public CommentModel GetById(Guid id)
        {
            var foundEntity = dbContextFactory
                .CreateDbContext()
                .Comments
                .FirstOrDefault(t => t.ID == id);
            return foundEntity == null ? null : Mapper.MapCommentModelFromEntity(foundEntity);
        }

        public void Update(CommentModel comment)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = Mapper.MapCommentModelToEntity(comment);
                dbContext.Comments.Update(entity);
                dbContext.SaveChanges();
            }
        }

        public CommentModel Add(CommentModel comment)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = Mapper.MapCommentModelToEntity(comment);
                dbContext.Comments.Add(entity);
                dbContext.SaveChanges();
                return Mapper.MapCommentModelFromEntity(entity);
            }
        }

        public void Remove(Guid id)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var comment = new CommentEntity
                {
                    ID = id
                };
                dbContext.Comments.Attach(comment);
                dbContext.Comments.Remove(comment);
                dbContext.SaveChanges();
            }
        }
    }
}