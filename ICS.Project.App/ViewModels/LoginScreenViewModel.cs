using System.Security;
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

        public LoginScreenViewModel(IUsersRepository usersRepository)
        {
            GoToRegisterScreenCommand = new RelayCommand(GoToRegisterScreen);
            TryToLoginCommand = new RelayCommand(TryToLogin, CanTryToLogin);

            _usersRepository = usersRepository;
        }

        public ICommand GoToRegisterScreenCommand { get; set; }
        public ICommand TryToLoginCommand { get; set; }

        public UserModel User { get; set; }
        public SecureString SecureStringPassword { get; set; }

        public void Load()
        {
            User = new UserModel();
            SecureStringPassword?.Clear();
        }

        public bool CanTryToLogin()
        {
            return !string.IsNullOrEmpty(User?.Email) && SecureStringPassword != null &&
                   SecureStringPassword.Length != 0;
        }

        public async void TryToLogin()
        {
            var userFromDb = _usersRepository.GetByEmail(User.Email);

            if (userFromDb == null)
            {
                await MaterialDesignThemes.Wpf.DialogHost.Show("Wrong email!", "TimeoutNotificationDialogHost");
                return;
            }

            var passwordHelper = new PasswordHelper();
            if (passwordHelper.IsPasswordCorrect(userFromDb, SecureStringPassword))
            {
                await MaterialDesignThemes.Wpf.DialogHost.Show($"Hi {userFromDb.Name}! Welcome back", "TimeoutNotificationDialogHost");
            }
            else
            {
                await MaterialDesignThemes.Wpf.DialogHost.Show("Wrong password!", "TimeoutNotificationDialogHost");
                return;
            }

            userFromDb.IsLoggedIn = true;
            _usersRepository.Update(userFromDb);

            Mediator.Instance.Send(new GoToMessengerScreenMessage());
            Mediator.Instance.Send(new UserLoggedMessage {User = userFromDb});
            SecureStringPassword?.Clear();
            User = null;
        }

        public void GoToRegisterScreen()
        {
            Mediator.Instance.Send(new GoToRegisterScreenMessage());
        }
    }
}