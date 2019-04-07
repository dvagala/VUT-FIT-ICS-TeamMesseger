using ICS.Project.BL.Models;
using ICS.Project.DAL.Entities;

namespace ICS.Project.BL.Mapper
{
    public interface IMapper
    {
        CommentEntity MapCommentModelToEntity(CommentModel model);
        CommentModel MapCommentModelFromEntity(CommentEntity comment);
        PostEntity MapPostModelToEntity(PostModel model);
        PostModel MapPostModelFromEntity(PostEntity post);
        TeamEntity MapTeamModelToEntity(TeamModel model);
        TeamModel MapTeamModelFromEntity(TeamEntity team);
        UserEntity MapUserModelToEntity(UserModel model);
        UserModel MapUserModelFromEntity(UserEntity user);
    }
}