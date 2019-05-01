using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels.MessengerScreenViewModels.ChatPanelViewModels
{
    public class UserInitialsCircleViewModel : ViewModelBase, IViewModel
    {

        public UserModel User { get; set; }

        public ICommand ShowUserDetailCommand { get; set; }


        public UserInitialsCircleViewModel()
        {
            ShowUserDetailCommand = new RelayCommand(ShowUserDetail);

        }

        public void ShowUserDetail()
        {
            MessageBox.Show($"{User.Name} {User.ID}");
        }

        public void Load()
        {
        }
    }
}