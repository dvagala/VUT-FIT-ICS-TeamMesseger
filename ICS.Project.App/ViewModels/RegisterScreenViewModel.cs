using System;
using System.ComponentModel.DataAnnotations;
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
    public class RegisterScreenViewModel : ViewModelBase, IViewModel
    {
        private readonly IUsersRepository _usersRepository;

        public RegisterScreenViewModel(IUsersRepository usersRepository)
        {
            GoToLoginScreenCommand = new RelayCommand(GoToLoginScreen);
            TryToRegisterCommand = new RelayCommand(TryToRegister, CanTryToRegister);

            _usersRepository = usersRepository;
        }

        public ICommand GoToLoginScreenCommand { get; set; }
        public ICommand TryToRegisterCommand { get; set; }

        public UserModel NewUser { get; set; }
        public SecureString SecureStringPassword { get; set; }

        public void Load()
        {
            SecureStringPassword?.Clear();
            NewUser = new UserModel();
        }

        public bool CanTryToRegister()
        {
            return !string.IsNullOrEmpty(NewUser?.Name) && !string.IsNullOrEmpty(NewUser?.Surname) &&
                   !string.IsNullOrEmpty(NewUser?.Email) && new EmailAddressAttribute().IsValid(NewUser.Email) &&
                   SecureStringPassword != null && SecureStringPassword.Length != 0 ;
        }


        public void TryToRegister()
        {
            if (_usersRepository.GetByEmail(NewUser.Email) != null)
            {
                MessageBox.Show("You are already registered!", "Registration failed");
                return;
            }

            var passwordHelper = new PasswordHelper();
            passwordHelper.AddEncryptedPasswordToUserModel(NewUser, SecureStringPassword);

            if (NewUser.PasswordHash == null || NewUser.Salt == null)
            {
                MessageBox.Show("Cant proccess password", "Registration failed");
                return;
            }

            var userFromDb = _usersRepository.Add(NewUser);

            if (userFromDb.ID == Guid.Empty)
            {
                MessageBox.Show("Error in database", "Registration failed");
                return;
            }

            userFromDb.IsLoggedIn = true;
            _usersRepository.Update(userFromDb);

            Mediator.Instance.Send(new GoToMessengerScreenMessage());
            Mediator.Instance.Send(new UserLoggedMessage {User = userFromDb});
            MessageBox.Show($"Hi {NewUser.Name}! Welcome to Team messenger", "Registration success");
            SecureStringPassword?.Clear();
            NewUser = null;
        }

        public void GoToLoginScreen()
        {
            Mediator.Instance.Send(new GoToLoginScreenMessage());
        }
    }
}