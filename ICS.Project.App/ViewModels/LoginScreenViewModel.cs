using System;
using System.Windows;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;
using System.Security;

namespace ICS.Project.App.ViewModels
{
    public class LoginScreenViewModel : ViewModelBase, IViewModel
    {
        private readonly IUsersRepository _usersRepository;

        public ICommand GoToRegisterScreenCommand { get; set; }
        public ICommand TryToLoginCommand { get; set; }

        public UserModel User { get; set; }
        public SecureString SecureStringPassword { get; set; }

        public LoginScreenViewModel(IUsersRepository usersRepository)
        {
            GoToRegisterScreenCommand = new RelayCommand(GoToRegisterScreen);
            TryToLoginCommand = new RelayCommand(TryToLogin, CanTryToLogin);

            _usersRepository = usersRepository;
        }

        public void Load()
        {
            User = new UserModel();
            SecureStringPassword?.Clear();
        }

        public bool CanTryToLogin()
        { 
            return !string.IsNullOrEmpty(User?.Email) && SecureStringPassword != null && SecureStringPassword.Length != 0;
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
            if (passwordHelper.IsPasswordCorrect(userFromDb, SecureStringPassword))
            {
                MessageBox.Show($"Hi {userFromDb.Name}! Welcome back", "Login success");
            }
            else
            {
                MessageBox.Show($"Wrong password!", "Login failed");
                return;
            }

            userFromDb.IsLoggedIn = true;
            _usersRepository.Update(userFromDb);

            Mediator.Instance.Send(new GoToMessengerScreenMessage());
            Mediator.Instance.Send(new UserLoggedMessage{ User = userFromDb});
            SecureStringPassword?.Clear();
            User = null;
        }

        public void GoToRegisterScreen()
        {
            Mediator.Instance.Send(new GoToRegisterScreenMessage());
        }
    }
}