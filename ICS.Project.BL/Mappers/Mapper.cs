using System.Linq;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.DAL.Entities;

namespace ICS.Project.BL.Mappers
{
    internal static class Mapper
    {
        public static CommentEntity MapCommentModelToEntity(CommentModel model)
        {
            return new CommentEntity
            {
                ID = model.ID,
                MessageText = model.MessageText,
                PublishDate = model.PublishDate,
                AuthorId = model.AuthorId,
                PostId = model.PostId
            };
        }

        public static CommentModel MapCommentModelFromEntity(CommentEntity comment)
        {
            return new CommentModel
            {
                ID = comment.ID,
                MessageText = comment.MessageText,
                PublishDate = comment.PublishDate,
                AuthorId = comment.AuthorId,
                PostId = comment.PostId
            };
        }

        public static CommentModel MapCommentModelFromEntityWithAuthor(CommentEntity comment)
        {
            return new CommentModel
            {
                ID = comment.ID,
                MessageText = comment.MessageText,
                PublishDate = comment.PublishDate,
                AuthorId = comment.AuthorId,
                PostId = comment.PostId,
                Author = MapUserModelFromEntity(comment.Author)
            };
        }

        public static PostEntity MapPostModelToEntity(PostModel model)
        {
            return new PostEntity
            {
                ID = model.ID,
                Title = model.Title,
                MessageText = model.MessageText,
                PublishDate = model.PublishDate,
                AuthorId = model.AuthorId,
                TeamId = model.TeamId
            };
        }

        public static PostModel MapPostModelFromEntity(PostEntity post)
        {
            return new PostModel
            {
                ID = post.ID,
                Title = post.Title,
                MessageText = post.MessageText,
                PublishDate = post.PublishDate,
                AuthorId = post.AuthorId,
                TeamId = post.TeamId
            };
        }
        

        public static PostModel MapPostModelFromEntityWithCommentsAndAuthor(PostEntity post)
        {
            return new PostModel
            {
                ID = post.ID,
                Title = post.Title,
                MessageText = post.MessageText,
                PublishDate = post.PublishDate,
                AuthorId = post.AuthorId,
                TeamId = post.TeamId,
                Author = MapUserModelFromEntity(post.Author),
                Comments = post.Comments.Select(MapCommentModelFromEntityWithAuthor).ToList()
            };
        }
        public static PostModel MapPostModelFromEntityWithAuthor(PostEntity post)
        {
            return new PostModel
            {
                ID = post.ID,
                Title = post.Title,
                MessageText = post.MessageText,
                PublishDate = post.PublishDate,
                AuthorId = post.AuthorId,
                TeamId = post.TeamId,
                Author = MapUserModelFromEntity(post.Author)
            };
        }

        public static TeamEntity MapTeamModelToEntity(TeamModel model)
        {
            return new TeamEntity
            {
                ID = model.ID,
                Name = model.Name,
                Description = model.Description
            };
        }

        public static TeamModel MapTeamModelFromEntity(TeamEntity team)
        {
            return new TeamModel
            {
                ID = team.ID,
                Name = team.Name,
                Description = team.Description
            };
        }


        public static UserEntity MapUserModelToEntity(UserModel model)
        {
            return new UserEntity
            {
                ID = model.ID,
                Name = model.Name,
                Surname = model.Surname,
                LastActivity = model.LastActivity,
                Email = model.Email,
                PasswordHash = model.PasswordHash,
                Salt = model.Salt,
                IterationCount = model.IterationCount
            };
        }

        public static UserModel MapUserModelFromEntity(UserEntity user)
        {
            return new UserModel
            {
                ID = user.ID,
                Name = user.Name,
                Surname = user.Surname,
                LastActivity = user.LastActivity,
                Email = user.Email,
                PasswordHash = user.PasswordHash,
                Salt = user.Salt,
                IterationCount= user.IterationCount
            };
        }
    }
}