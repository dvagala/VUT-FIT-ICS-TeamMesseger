using System;
using System.Collections.Generic;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Repositories
{
    public interface ITeamsRepository
    {
        IEnumerable<UserModel> GetTeamMembers(Guid teamId);
        void AddUserToTeam(Guid userId, Guid teamId);
        void RemoveUserFromTeam(Guid userId, Guid teamId);
        IEnumerable<TeamModel> GetUserTeams(Guid userId);
        IEnumerable<PostModel> GetPostsWithCommentsAndAuthors(Guid teamId);
        void RemoveWithAllPostsAndComments(Guid id);
        IList<TeamModel> GetAll();
        TeamModel GetFirst();
        TeamModel GetById(Guid id);
        void Update(TeamModel team);
        TeamModel Add(TeamModel team);
        void Remove(Guid id);
    }
}