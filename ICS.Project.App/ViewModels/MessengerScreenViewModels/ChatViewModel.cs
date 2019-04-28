using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.App.ViewModels.MessengerScreenViewModels.ChatPanelViewModels;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels.MessengerScreenViewModels
{
    public class ChatViewModel : ViewModelBase, IViewModel
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IMediator _mediator;

        public ObservableCollection<PostViewModel> PostsVMs { get; set; } = new ObservableCollection<PostViewModel>();


        public ICommand GoToRegisterScreenCommand { get; set; }
        public ICommand TryToLoginCommand { get; set; }

        public UserModel User { get; set; }
        public string PlainTextPassword { get; set; }


        public ChatViewModel(IUsersRepository usersRepository, IMediator mediator)
        {
            GoToRegisterScreenCommand = new RelayCommand(GoToRegisterScreen);
            TryToLoginCommand = new RelayCommand(TryToLogin, CanTryToLogin);

            _usersRepository = usersRepository;
            _mediator = mediator;

            PostsVMs.Add(new PostViewModel { Post = new PostModel{ Title = "FirstPost", MessageText = "s simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. " }});
            PostsVMs.Add(new PostViewModel { Post = new PostModel { Title = "SecPost", MessageText = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it " }});
            PostsVMs.Add(new PostViewModel { Post = new PostModel { Title = "ThirdtPost" }});
            PostsVMs.Add(new PostViewModel { Post = new PostModel { Title = "ThirdtPost" }});
            PostsVMs.Add(new PostViewModel { Post = new PostModel{ Title = "ThirdtPost" }});
        }

        public void Load()
        {
            PlainTextPassword = "";
            User = new UserModel();
        }

        public bool CanTryToLogin()
        {
            return !string.IsNullOrEmpty(User?.Email) && !string.IsNullOrEmpty(PlainTextPassword);
        }

        public void TryToLogin()
        {
            UserModel userFromDb = _usersRepository.GetByEmail(User.Email);

            if (userFromDb == null)
            {
                MessageBox.Show($"Wrong email!", "Login failed");
                return;
            }

            PasswordHelper passwordHelper = new PasswordHelper();
            if (passwordHelper.IsPasswordCorrect(PlainTextPassword, userFromDb))
            {
                MessageBox.Show($"Hi {userFromDb.Name}! Welcome back", "Login success");
            }
            else
            {
                MessageBox.Show($"Wrong password!", "Login failed");
                return;
            }

            _mediator.Send(new GoToMessengerScreenMessage());
            PlainTextPassword = "";
            User = null;
        }

        public void GoToRegisterScreen()
        {
            _mediator.Send(new GoToRegisterScreenMessage());
        }
    }
}