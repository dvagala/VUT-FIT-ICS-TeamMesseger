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

        public OptionsPanelViewModel(IUsersRepository usersRepository)
        {
            DeleteAccountCommand = new RelayCommand(DeleteAccount);
            LogoutCommand = new RelayCommand(Logout);
            RefreshCommand = new RelayCommand(Refresh);

            _usersRepository = usersRepository;
        }

        public ICommand LogoutCommand { get; set; }
        public ICommand DeleteAccountCommand { get; set; }
        public ICommand RefreshCommand { get; set; }

        public UserModel User { get; set; }
        public string PlainTextPassword { get; set; }

        public void Load()
        {
            PlainTextPassword = "";
            User = new UserModel();
        }

        public void DeleteAccount()
        {
        }

        private void Logout()
        {
            Mediator.Instance.Send(new GoToLoginScreenMessage());
            Mediator.Instance.Send(new UserLogoutMessage());
        }

        private void Refresh()
        {
            Mediator.Instance.Send(new RefreshDataInMesssengerScreenMessage());
        }
    }
}