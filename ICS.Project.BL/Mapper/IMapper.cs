using System;
using System.Collections.Generic;
using System.Text;
using ICS.Project.DAL.Entities;
using ICS.Project.BL.Models;

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
