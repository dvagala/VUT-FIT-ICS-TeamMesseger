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
    public class CommentsRepository : ICommentsRepository
    {
        private readonly IDbContextFactory dbContextFactory;
        private readonly IMapper mapper;

        public CommentsRepository(IDbContextFactory dbContextFactory, IMapper mapper)
        {
            this.dbContextFactory = dbContextFactory;
            this.mapper = mapper;
        }

        public IEnumerable<CommentModel> GetAll()
        {
            return dbContextFactory.CreateDbContext()
                .Comments
                .Select(mapper.MapCommentModelFromEntity);
        }

        public CommentModel GetById(Guid id)
        {
            var foundEntity = dbContextFactory
                .CreateDbContext()
                .Comments
                .FirstOrDefault(t => t.ID == id);
            return foundEntity == null ? null : mapper.MapCommentModelFromEntity(foundEntity);
        }

        public void Update(CommentModel comment)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = mapper.MapCommentModelToEntity(comment);
                dbContext.Comments.Update(entity);
                dbContext.SaveChanges();
            }
        }

        public CommentModel Add(CommentModel comment)
        {
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                var entity = mapper.MapCommentModelToEntity(comment);
                dbContext.Comments.Add(entity);
                dbContext.SaveChanges();
                return mapper.MapCommentModelFromEntity(entity);
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
