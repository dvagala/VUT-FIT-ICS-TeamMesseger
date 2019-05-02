using System;
using System.Linq;
using System.Windows;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.App.ViewModels.MessengerScreenViewModels;
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

        private readonly ITeamsRepository teamsRepository;
        private readonly IUsersRepository usersRepository;
        private readonly IPostsRepository postsRepository;
        private readonly ICommentsRepository commentsRepository;

        public ViewModelBase CurrentViewModel { get; set; }


        public LoginScreenViewModel LoginScreenViewModel { get; }
        public RegisterScreenViewModel RegisterScreenViewModel { get; }
        public OptionsPanelViewModel OptionsPanelViewModel { get; }
        public TeamsListViewModel TeamsListViewModel { get; }
        public TeamDetailViewModel TeamDetailViewModel { get; }
        public ChatPanelViewModel ChatPanelViewModel { get; }

        public ViewModelLocator()
        {
            dbContextFactory = new DefaultDbContextFactory();

            mediator = new Mediator();

            mediator.Register<GoToRegisterScreenMessage>(GoToRegisterScreen);
            mediator.Register<GoToLoginScreenMessage>(GoToLoginScreen);
            mediator.Register<GoToMessengerScreenMessage>(GoToMessengerScreen);

            teamsRepository = new TeamsRepository(dbContextFactory);
            usersRepository = new UsersRepository(dbContextFactory);
            postsRepository = new PostsRepository(dbContextFactory);
            commentsRepository = new CommentsRepository(dbContextFactory);

            LoginScreenViewModel = new LoginScreenViewModel(usersRepository, mediator);
            RegisterScreenViewModel = new RegisterScreenViewModel(usersRepository, mediator);

            OptionsPanelViewModel = new OptionsPanelViewModel(usersRepository, mediator);
            TeamsListViewModel = new TeamsListViewModel(teamsRepository, mediator);
            TeamDetailViewModel = new TeamDetailViewModel(usersRepository, teamsRepository, mediator);
            ChatPanelViewModel = new ChatPanelViewModel(teamsRepository, postsRepository, commentsRepository, mediator);

            CurrentViewModel = LoginScreenViewModel;

//            // Hack: Default logged user is student admin
//            CurrentViewModel = ChatPanelViewModel;
//            mediator.Send(new UserLoggedMessage { User = usersRepository.GetById(new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83")) });
//            mediator.Send(new SelectedTeamMessage { Team = teamsRepository.GetUserTeams(new Guid("ec16e27a-47e2-4f47-b19d-0a362003ca83")).First()});
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
            CurrentViewModel = ChatPanelViewModel;
        }
    }
}
