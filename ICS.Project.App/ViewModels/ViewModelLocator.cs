using ICS.Project.BL.Repositories;
using ICS.Project.DAL;

namespace ICS.Project.App.ViewModels
{
    public class ViewModelLocator
    {
        private readonly IDbContextFactory dbContextFactory;
        private readonly ITeamsRepository teamRepository;

        public TeamsListViewModel TeamsListViewModel => new TeamsListViewModel(teamRepository);
        public TeamDetailViewModel TeamDetailViewModel => new TeamDetailViewModel(teamRepository);

        public ViewModelLocator()
        {
            dbContextFactory = new DefaultDbContextFactory();
            teamRepository = new TeamsRepository(dbContextFactory);
        }
    }
}
