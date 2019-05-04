using System.Linq;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;
using MaterialDesignThemes.Wpf;

namespace ICS.Project.App.ViewModels.MessengerScreenViewModels
{
    public class OptionsPanelViewModel : ViewModelBase, IViewModel
    {
        public OptionsPanelViewModel()
        {
            LogoutCommand = new RelayCommand(Logout);
            RefreshCommand = new RelayCommand(Refresh);

            Mediator.Instance.Register<UserLoggedMessage>(UserLogged);
        }

        public ICommand LogoutCommand { get; set; }
        public ICommand DeleteAccountCommand { get; set; }
        public ICommand RefreshCommand { get; set; }

        public UserModel LoggedUser { get; set; }

        public void Load()
        {
        }

        private void UserLogged(UserLoggedMessage userLoggedMessage)
        {
            LoggedUser = userLoggedMessage.User;
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