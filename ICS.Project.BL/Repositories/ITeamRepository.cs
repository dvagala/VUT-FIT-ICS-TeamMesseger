using System;
using System.Collections.Generic;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Repositories
{
    public interface ITeamsRepository
    {
        IEnumerable<TeamModel> GetAll();
        TeamModel GetById(Guid id);
        void Update(TeamModel post);
        TeamModel Add(TeamModel post);
        void Remove(Guid id);
    }
}