using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Models;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels.MessengerScreenViewModels.ChatPanelViewModels
{
    public class UserInitialsCircleViewModel : ViewModelBase, IViewModel
    {
        public UserInitialsCircleViewModel()
        {
            ShowUserDetailCommand = new RelayCommand(ShowUserDetail);
        }

        public ICommand ShowUserDetailCommand { get; set; }

        public UserModel User { get; set; }

        public void Load()
        {
        }

        public void ShowUserDetail()
        {
            Mediator.Instance.Send(new UserWasClickedMessage {User = User});
        }
    }
}