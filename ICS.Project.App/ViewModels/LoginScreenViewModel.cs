using System.Windows;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels
{
    public class LoginScreenViewModel : ViewModelBase, IViewModel
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IMediator _mediator;

        public ICommand GoToRegisterScreenCommand { get; set; }
        public ICommand TryToLoginCommand { get; set; }

        public UserModel User { get; set; }
        public string PlainTextPassword { get; set; }


        public LoginScreenViewModel(IUsersRepository usersRepository, IMediator mediator)
        {
            GoToRegisterScreenCommand = new RelayCommand(GoToRegisterScreen);
            TryToLoginCommand = new RelayCommand(TryToLogin, CanTryToLogin);

            _usersRepository = usersRepository;
            _mediator = mediator;
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
            _mediator.Send(new UserLoggedMessage{ User = userFromDb});
            PlainTextPassword = "";
            User = null;
        }

        public void GoToRegisterScreen()
        {
            _mediator.Send(new GoToRegisterScreenMessage());
        }
    }
}