using System;
using System.Collections.Generic;
using System.Text;
using ICS.Project.BL.Models;

namespace ICS.Project.BL.Repositories
{
    public interface ITeamRepository
    {
        IEnumerable<TeamModel> GetAll();
        TeamModel GetById(Guid id);
        void Update(TeamModel post);
        TeamModel Add(TeamModel post);
        void Remove(Guid id);
    }
}
