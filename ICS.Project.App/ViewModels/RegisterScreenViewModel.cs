using System;
using System.Windows;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;
using System.ComponentModel.DataAnnotations;
using ICS.Project.App.ViewModels.BaseViewModels;

namespace ICS.Project.App.ViewModels
{
    public class RegisterScreenViewModel : ViewModelBase, IViewModel
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IMediator _mediator;

        public ICommand GoToLoginScreenCommand { get; set; }
        public ICommand TryToRegisterCommand { get; set; }

        public UserModel NewUser { get; set; }

        public string PlainTextPassword { get; set; }


        public RegisterScreenViewModel(IUsersRepository usersRepository, IMediator mediator)
        {
            GoToLoginScreenCommand = new RelayCommand(GoToLoginScreen);
            TryToRegisterCommand = new RelayCommand(TryToRegister, CanTryToRegister);

            _usersRepository = usersRepository;
            _mediator = mediator;

        }

        public void Load()
        {
            PlainTextPassword = "";
            NewUser = new UserModel();
        }

        public bool CanTryToRegister()
        {
            return !string.IsNullOrEmpty(NewUser?.Name) && !string.IsNullOrEmpty(NewUser?.Surname) &&
                   !string.IsNullOrEmpty(NewUser?.Email) && !string.IsNullOrEmpty(PlainTextPassword) && new EmailAddressAttribute().IsValid(NewUser.Email);
        }


        public void TryToRegister()
        {
            if (_usersRepository.GetByEmail(NewUser.Email) != null)
            {
                MessageBox.Show($"You are already registered!", "Registration failed");
                return;
            }

            PasswordHelper passwordHelper = new PasswordHelper();
            passwordHelper.AddEncryptedPasswordToUserModel(NewUser, PlainTextPassword);

            if (NewUser.PasswordHash == null || NewUser.Salt == null)
            {
                MessageBox.Show($"Cant proccess password", "Registration failed");
                return;
            }

            UserModel savedUser =_usersRepository.Add(NewUser);

            if (savedUser.ID == Guid.Empty)
            {
                MessageBox.Show($"Error in database", "Registration failed");
                return;
            }

            _mediator.Send(new GoToMessengerScreenMessage());
            MessageBox.Show($"Hi {NewUser.Name}! Welcome to Team messenger", "Registration success");
            PlainTextPassword = "";
            NewUser = null;
        }

        public void GoToLoginScreen()
        {
            _mediator.Send(new GoToLoginScreenMessage());
        }
    }
}
