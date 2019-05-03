using System.Threading;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.App.ViewModels.MessengerScreenViewModels;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;
using ICS.Project.DAL;

namespace ICS.Project.App.ViewModels
{
    public class ViewModelLocator : ViewModelBase
    {
        public ViewModelLocator()
        {
            IDbContextFactory dbContextFactory = new DefaultDbContextFactory();

            Mediator.Instance.Register<GoToRegisterScreenMessage>(GoToRegisterScreen);
            Mediator.Instance.Register<GoToLoginScreenMessage>(GoToLoginScreen);
            Mediator.Instance.Register<GoToMessengerScreenMessage>(GoToMessengerScreen);
            Mediator.Instance.Register<UserClosedMainWindowMessage>(UserClosedMainWindow);

            ITeamsRepository teamsRepository = new TeamsRepository(dbContextFactory);
            IUsersRepository usersRepository = new UsersRepository(dbContextFactory);
            IPostsRepository postsRepository = new PostsRepository(dbContextFactory);
            ICommentsRepository commentsRepository = new CommentsRepository(dbContextFactory);

            LoginScreenViewModel = new LoginScreenViewModel(usersRepository);
            RegisterScreenViewModel = new RegisterScreenViewModel(usersRepository);

            OptionsPanelViewModel = new OptionsPanelViewModel(usersRepository);
            SearchPanelViewModel = new SearchPanelViewModel();
            TeamsListViewModel = new TeamsListViewModel(teamsRepository);
            TeamDetailViewModel = new TeamDetailViewModel(usersRepository, teamsRepository);
            ChatPanelViewModel =
                new ChatPanelViewModel(teamsRepository, postsRepository, commentsRepository, usersRepository);
            UserDetailScreenViewModel = new UserDetailScreenViewModel(teamsRepository, usersRepository);

            CurrentViewModel = LoginScreenViewModel;

            // To speed up later database access
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                usersRepository.GetFirst();
            }).Start();
        }

        public ViewModelBase CurrentViewModel { get; set; }
        public LoginScreenViewModel LoginScreenViewModel { get; }
        public RegisterScreenViewModel RegisterScreenViewModel { get; }
        public OptionsPanelViewModel OptionsPanelViewModel { get; }
        public SearchPanelViewModel SearchPanelViewModel { get; }
        public TeamsListViewModel TeamsListViewModel { get; }
        public TeamDetailViewModel TeamDetailViewModel { get; }
        public ChatPanelViewModel ChatPanelViewModel { get; }
        public UserDetailScreenViewModel UserDetailScreenViewModel { get; }

        public void UserClosedMainWindow(UserClosedMainWindowMessage message)
        {
            if (CurrentViewModel == ChatPanelViewModel) Mediator.Instance.Send(new UserLogoutMessage());
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