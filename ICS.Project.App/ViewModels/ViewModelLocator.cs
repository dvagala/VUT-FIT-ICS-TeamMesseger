using System.Windows;
using ICS.Project.App.Views;
using ICS.Project.BL.Messages;
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


        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }


        public LoginScreenViewModel LoginScreenViewModel { get; }
        public RegisterScreenViewModel RegisterScreenViewModel { get; }
        public TeamsListViewModel TeamsListViewModel { get; }
        public TeamDetailViewModel TeamDetailViewModel { get; }

        public ViewModelLocator()
        {
            dbContextFactory = new DefaultDbContextFactory();

            mediator = new Mediator();

            mediator.Register<GoToRegisterScreenMessage>(GoToRegisterScreen);
            mediator.Register<GoToLoginScreenMessage>(GoToLoginScreen);
            mediator.Register<GoToMessengerScreenMessage>(GoToMessengerScreen);

            teamRepository = new TeamsRepository(dbContextFactory);

            TeamDetailViewModel = new TeamDetailViewModel(teamRepository, mediator); 
            LoginScreenViewModel = new LoginScreenViewModel(teamRepository, mediator);
            RegisterScreenViewModel = new RegisterScreenViewModel(teamRepository, mediator);
            TeamsListViewModel = new TeamsListViewModel(teamRepository, mediator);

            CurrentViewModel = LoginScreenViewModel;
        }

        public void GoToLoginScreen(GoToLoginScreenMessage message)
        {
            CurrentViewModel = LoginScreenViewModel;
        }

        public void GoToRegisterScreen(GoToRegisterScreenMessage message)
        {
            CurrentViewModel = RegisterScreenViewModel;
        }

        public void GoToMessengerScreen(GoToMessengerScreenMessage message)
        {
            CurrentViewModel = TeamsListViewModel;
        }
    }
}
