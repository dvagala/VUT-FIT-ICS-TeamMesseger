using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels
{
    public class LoginScreenViewModel : ViewModelBase, IViewModel
    {
        private readonly IMediator _mediator;



        public ICommand GoToRegisterScreenCommand { get; set; }
        public ICommand TryToLoginCommand { get; set; }


        public LoginScreenViewModel(ITeamsRepository teamsRepository, IMediator mediator)
        {
            GoToRegisterScreenCommand = new RelayCommand(GoToRegisterScreen);
            TryToLoginCommand = new RelayCommand(TryToLogin);

            _mediator = mediator;
        }

        public void Load()
        {

        }

        public void TryToLogin()
        {
            _mediator.Send(new GoToMessengerScreenMessage());
        }

        public void GoToRegisterScreen()
        {
            _mediator.Send(new GoToRegisterScreenMessage());
        }
    }
}