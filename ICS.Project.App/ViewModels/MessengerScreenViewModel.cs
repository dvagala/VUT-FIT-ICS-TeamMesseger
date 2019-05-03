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
    public class MessengerScreenViewModel : ViewModelBase, IViewModel
    {
        private readonly IUsersRepository _usersRepository;


        public TeamModel Team { get; set; }


        public MessengerScreenViewModel(IUsersRepository usersRepository)
        {

        }

        public void Load()
        { 
        }

        private void TeamSelected(SelectedTeamMessage selectedTeamMessage)
        {
            Team = selectedTeamMessage.Team;
        }
    }
}