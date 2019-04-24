using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;
using ICS.Project.DAL;

namespace ICS.Project.App.ViewModels
{
    public class ViewModelLocator
    {
        private readonly IMediator mediator;
        private readonly IDbContextFactory dbContextFactory;
        private readonly ITeamsRepository teamRepository;

        public TeamsListViewModel TeamsListViewModel => new TeamsListViewModel(teamRepository, mediator);
        public TeamDetailViewModel TeamDetailViewModel => new TeamDetailViewModel(teamRepository, mediator);


        public ViewModelLocator()
        {
            dbContextFactory = new DefaultDbContextFactory();

            mediator = new Mediator();

            teamRepository = new TeamsRepository(dbContextFactory);
        }
    }
}
