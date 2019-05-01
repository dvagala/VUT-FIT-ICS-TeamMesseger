using System.Collections.ObjectModel;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels.MessengerScreenViewModels
{
    public class TeamsListViewModel : ViewModelBase, IViewModel
    {
        private readonly ITeamsRepository _teamsRepository;
        private readonly IMediator _mediator;

        public TeamModel NewTeam { get; set; }

        public ObservableCollection<TeamModel> Teams { get; set; } = new ObservableCollection<TeamModel>();


        public ICommand AddNewTeamCommand { get; set; }
        public ICommand TeamSelectedCommand { get; set; }
        public string Mock { get; set; }


        public TeamsListViewModel(ITeamsRepository teamsRepository, IMediator mediator)
        {
            AddNewTeamCommand = new RelayCommand(AddNewTeam, CanAddNewTeam);
            TeamSelectedCommand = new RelayCommand<TeamModel>(TeamSelected);

            _mediator = mediator;
            _teamsRepository = teamsRepository;

            NewTeam = new TeamModel();
        }

        public void Load()
        {
            Teams.Clear();
            foreach (var team in _teamsRepository.GetAll()) Teams.Add(team);
        }


        public void AddNewTeam()
        {
            _teamsRepository.Add(NewTeam);
            NewTeam = new TeamModel();
            Load();
        }

        private bool CanAddNewTeam()
        {
            return NewTeam != null && !string.IsNullOrWhiteSpace(NewTeam.Name);
        }

        private void TeamSelected(TeamModel selectedTeamModel)
        {
            _mediator.Send(new SelectedTeamMessage{ Team= selectedTeamModel});
        }


    }
}