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
        private readonly IMediator _mediator;

        public UserModel LoggedUser { get; set; }
        public TeamModel NewTeam { get; set; }
        public ObservableCollection<TeamModel> Teams { get; set; } = new ObservableCollection<TeamModel>();

        public int SelectedIndexInListBox { get; set; }

        public ICommand AddNewTeamCommand { get; set; }
        public ICommand TeamSelectedCommand { get; set; }

        public TeamsListViewModel(ITeamsRepository teamsRepository, IMediator mediator)
        {
            AddNewTeamCommand = new RelayCommand(AddNewTeam, CanAddNewTeam);
            TeamSelectedCommand = new RelayCommand<TeamModel>(TeamSelected);

            _mediator = mediator;
            _teamsRepository = teamsRepository;

            NewTeam = new TeamModel();

            _mediator.Register<UserLoggedMessage>(UserLogged);
            _mediator.Register<UserRemovedHimselfFromTeamMessage>(UserRemovedHimselfFromTeam);
            _mediator.Register<RefreshDataInMesssengerScreenMessage>(RefreshDataInMesssengerScreen);
        }

        private void UserLogged(UserLoggedMessage userLoggedMessage)
        {
            LoggedUser = userLoggedMessage.User;
            Refresh();
            SelectedIndexInListBox = 0;
        }

        public void Load()
        {
        }

        public void UserRemovedHimselfFromTeam(UserRemovedHimselfFromTeamMessage userRemovedHimselfFromTeamMessage)
        {
            int oldSelectedIndex = SelectedIndexInListBox;
            Teams.Remove(userRemovedHimselfFromTeamMessage.Team);

            if (Teams.Count == oldSelectedIndex)
            {
                SelectedIndexInListBox = oldSelectedIndex - 1;
            }
            else
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
            SelectedIndexInListBox = oldSelectedIndex;
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
            _mediator.Send(new SelectedTeamMessage{ Team = selectedTeamModel});
        }
    }
}