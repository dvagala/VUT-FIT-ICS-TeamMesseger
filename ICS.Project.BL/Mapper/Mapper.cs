using System.Linq;
using ICS.Project.BL.Models;
using ICS.Project.DAL.Entities;

namespace ICS.Project.BL.Mapper
{
    public class Mapper : IMapper
    {
        public CommentEntity MapCommentModelToEntity(CommentModel model)
        {
            return new CommentEntity
            {
                ID = model.ID,
                Autor = MapUserModelToEntity(model.Autor),
                MessageText = model.MessageText,
                PublishDate = model.PublishDate
            };
        }

        public CommentModel MapCommentModelFromEntity(CommentEntity comment)
        {
            return new CommentModel
            {
                ID = comment.ID,
                Autor = MapUserModelFromEntity(comment.Autor),
                MessageText = comment.MessageText,
                PublishDate = comment.PublishDate
            };
        }

        public PostEntity MapPostModelToEntity(PostModel model)
        {
            return new PostEntity
            {
                ID = model.ID,
                Title = model.Title,
                MessageText = model.MessageText,
                PublishDate = model.PublishDate,
                Comments = model.Comments
                    .Select(x => MapCommentModelToEntity(x))
                    .ToList()
            };
        }

        public PostModel MapPostModelFromEntity(PostEntity post)
        {
            return new PostModel
            {
                ID = post.ID,
                Title = post.Title,
                MessageText = post.MessageText,
                PublishDate = post.PublishDate,
                Comments = post.Comments
                    .Select(x => MapCommentModelFromEntity(x))
                    .ToList()
            };
        }

        public TeamEntity MapTeamModelToEntity(TeamModel model)
        {
            return new TeamEntity
            {
                ID = model.ID,
                Name = model.Name,
                Description = model.Description,
                Posts = model.Posts
                    .Select(x => MapPostModelToEntity(x))
                    .ToList()
            };
        }

        public TeamModel MapTeamModelFromEntity(TeamEntity team)
        {
            return new TeamModel
            {
                ID = team.ID,
                Name = team.Name,
                Description = team.Description,
                Posts = team.Posts
                    .Select(x => MapPostModelFromEntity(x))
                    .ToList()
            };
        }


        public UserEntity MapUserModelToEntity(UserModel model)
        {
            return new UserEntity
            {
                ID = model.ID,
                Name = model.Name,
                Surname = model.Surname,
                LastActivity = model.LastActivity,
                Email = model.Email,
                Password = model.Password,
                Teams = model.Teams
                    .Select(x => MapTeamModelToEntity(x))
                    .ToList()
            };
        }

        public UserModel MapUserModelFromEntity(UserEntity user)
        {
            return new UserModel
            {
                ID = user.ID,
                Name = user.Name,
                Surname = user.Surname,
                LastActivity = user.LastActivity,
                Email = user.Email,
                Password = user.Password,
                Teams = user.Teams
                    .Select(x => MapTeamModelFromEntity(x))
                    .ToList()
            };
        }
    }
}