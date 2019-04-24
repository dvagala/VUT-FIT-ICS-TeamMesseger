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
        IList<TeamModel> GetAll();
        TeamModel GetFirst();
        TeamModel GetById(Guid id);
        void Update(TeamModel post);
        TeamModel Add(TeamModel post);
        void Remove(Guid id);
    }
}