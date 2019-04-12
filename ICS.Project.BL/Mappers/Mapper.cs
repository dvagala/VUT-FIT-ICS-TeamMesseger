using ICS.Project.BL.Models;
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
                AutorId = model.AutorId,
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
                AutorId = comment.AutorId,
                PostId = comment.PostId
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
                AutorId = model.AutorId
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
                AutorId = post.AutorId
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
                Password = model.Password
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
                Password = user.Password
            };
        }
    }
}