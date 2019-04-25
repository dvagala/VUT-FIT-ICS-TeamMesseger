using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;
using ICS.Project.DAL;

namespace ICS.Project.App.ViewModels
{
    public class ViewModelLocator : ViewModelBase
    {
        private readonly IMediator mediator;
        private readonly IDbContextFactory dbContextFactory;
        private readonly ITeamsRepository teamRepository;

        public enum ViewStateEnum { Login, Register, Messenger};

        private ViewStateEnum _CurrentViewState;
        public ViewStateEnum CurrentViewState
        {
            get => _CurrentViewState;
            set
            {
                _CurrentViewState = value;
                OnPropertyChanged();
            }
        }

        public TeamsListViewModel TeamsListViewModel => new TeamsListViewModel(teamRepository, mediator);
        public TeamDetailViewModel TeamDetailViewModel => new TeamDetailViewModel(teamRepository, mediator);


        public ViewModelLocator()
        {
            CurrentViewState = ViewStateEnum.Login;

            dbContextFactory = new DefaultDbContextFactory();

            mediator = new Mediator();

            teamRepository = new TeamsRepository(dbContextFactory);            
        }
    }
}
