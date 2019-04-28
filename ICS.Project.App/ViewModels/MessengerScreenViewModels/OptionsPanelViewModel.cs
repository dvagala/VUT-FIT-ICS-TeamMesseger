using System.Windows;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels.MessengerScreenViewModels
{
    public class OptionsPanelViewModel : ViewModelBase, IViewModel
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IMediator _mediator;

        public ICommand ChangeEmailCommand { get; set; }
        public ICommand ChangePasswordCommand { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand DeleteAccountCommand { get; set; }
        public ICommand RefreshCommand { get; set; }

        public UserModel User { get; set; }
        public string PlainTextPassword { get; set; }


        public OptionsPanelViewModel(IUsersRepository usersRepository, IMediator mediator)
        {
            ChangeEmailCommand = new RelayCommand(ChangeEmail);
            ChangePasswordCommand = new RelayCommand(ChangePassword);
            DeleteAccountCommand = new RelayCommand(DeleteAccount);
            LogoutCommand = new RelayCommand(Logout);
            RefreshCommand = new RelayCommand(Refresh);

            _usersRepository = usersRepository;
            _mediator = mediator;
        }

        public void Load()
        {
            PlainTextPassword = "";
            User = new UserModel();
        }

        public void ChangePassword()
        {

        }

        public void ChangeEmail()
        {
            MessageBox.Show("changemeil");
        }

        public void DeleteAccount()
        {

        }

        private void Logout()
        {
            _mediator.Send(new GoToLoginScreenMessage());
        }

        private void Refresh()
        {
        }
    }
}