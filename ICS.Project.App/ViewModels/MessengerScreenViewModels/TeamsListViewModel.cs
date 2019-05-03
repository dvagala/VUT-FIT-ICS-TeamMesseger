using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;
using Microsoft.EntityFrameworkCore.Internal;

namespace ICS.Project.App.ViewModels.MessengerScreenViewModels
{
    public class TeamsListViewModel : ViewModelBase, IViewModel
    {
        private readonly ITeamsRepository _teamsRepository;

        public UserModel LoggedUser { get; set; }
        public TeamModel NewTeam { get; set; }
        public ObservableCollection<TeamModel> Teams { get; set; } = new ObservableCollection<TeamModel>();

        public int SelectedIndexInListBox { get; set; }

        public ICommand AddNewTeamCommand { get; set; }
        public ICommand TeamSelectedCommand { get; set; }

        public TeamsListViewModel(ITeamsRepository teamsRepository)
        {
            AddNewTeamCommand = new RelayCommand(AddNewTeam, CanAddNewTeam);
            TeamSelectedCommand = new RelayCommand<TeamModel>(TeamSelected);

            _teamsRepository = teamsRepository;

            Mediator.Instance.Register<UserLoggedMessage>(UserLogged);
            Mediator.Instance.Register<UserLogoutMessage>(UserLogout);
            Mediator.Instance.Register<UserLostAccessToTeam>(RemoveTeamInListView);
            Mediator.Instance.Register<RefreshDataInMesssengerScreenMessage>(RefreshDataInMesssengerScreen);
        }

        private void UserLogged(UserLoggedMessage userLoggedMessage)
        {
            LoggedUser = userLoggedMessage.User;
        }

        private void UserLogout(UserLogoutMessage userLoggedMessage)
        {
            LoggedUser = null;
            NewTeam = null;
            Teams.Clear();
        }

        public void Load()
        {
            NewTeam = new TeamModel();
            SelectedIndexInListBox = 0;

            Refresh();

            Mediator.Instance.Send(new SelectedTeamMessage { Team = _teamsRepository.GetUserTeams(LoggedUser.ID).FirstOrDefault() });
        }

        public void RemoveTeamInListView(UserLostAccessToTeam userLostAccessToTeam)
        {
            int oldSelectedIndex = SelectedIndexInListBox;
            Teams.Remove(Teams.Single(i => i.ID == userLostAccessToTeam.Team.ID));

            if (!Teams.Any())
            {
                Mediator.Instance.Send(new SelectedTeamMessage { Team = null });
            }

            // Deleting item at the bottom
            if (Teams.Count == oldSelectedIndex)
            {
                SelectedIndexInListBox = oldSelectedIndex - 1;
            }
            else  // Deleting item in the middle
            {
                SelectedIndexInListBox = oldSelectedIndex;
            }
        }

        public void RefreshDataInMesssengerScreen(RefreshDataInMesssengerScreenMessage refreshDataInMesssengerScreenMessage)
        {
            Refresh();
        }

        public void Refresh()
        {
            int oldSelectedIndex = SelectedIndexInListBox;
            Teams.Clear();
            foreach (var team in _teamsRepository.GetUserTeams(LoggedUser.ID)) Teams.Add(team);

            if (!Teams.Any())
            {
                Mediator.Instance.Send(new SelectedTeamMessage { Team = null });
            }

            if (oldSelectedIndex < 0 || oldSelectedIndex >= Teams.Count)
            {
                SelectedIndexInListBox = 0;
            }
            else
            {
                SelectedIndexInListBox = oldSelectedIndex;
            }
        }

        public void AddNewTeam()
        {
            TeamModel teamFromDb = _teamsRepository.Add(NewTeam);
            _teamsRepository.AddUserToTeam(LoggedUser.ID, teamFromDb.ID);

            NewTeam = new TeamModel();
            Refresh();

            SelectedIndexInListBox = _teamsRepository.GetUserTeams(LoggedUser.ID).ToList()
                .FindIndex(s => s.ID == teamFromDb.ID);
        }

        private bool CanAddNewTeam()
        {
            return NewTeam != null && !string.IsNullOrWhiteSpace(NewTeam.Name);
        }

        private void TeamSelected(TeamModel selectedTeamModel)
        {
            Mediator.Instance.Send(new SelectedTeamMessage{ Team = selectedTeamModel});
        }
    }
}