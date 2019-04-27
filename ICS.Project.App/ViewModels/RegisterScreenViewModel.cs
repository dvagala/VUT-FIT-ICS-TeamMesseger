using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels
{
    public class RegisterScreenViewModel : ViewModelBase, IViewModel
    {
        private readonly IMediator _mediator;

        public ICommand GoToLoginScreenCommand { get; set; }


        public RegisterScreenViewModel(ITeamsRepository teamsRepository, IMediator mediator)
        {
            GoToLoginScreenCommand = new RelayCommand(GoToLoginScreen);

            _mediator = mediator;

        }

        public void Load()
        {

        }

        public void GoToLoginScreen()
        {
            _mediator.Send(new GoToLoginScreenMessage());
        }
    }
}
