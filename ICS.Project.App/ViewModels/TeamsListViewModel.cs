using System.Collections.ObjectModel;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;

namespace ICS.Project.App.ViewModels
{
    public class TeamsListViewModel : ViewModelBase, IViewModel
    {
        private readonly ITeamsRepository _teamsRepository;


        public TeamsListViewModel(ITeamsRepository teamsRepository)
        {
            NewTeamAddedCommand = new RelayCommand(AddNewTeam, CanAddNewTeam);

            _teamsRepository = teamsRepository;
        }

        public TeamModel NewTeam { get; set; } = new TeamModel();

        public ObservableCollection<TeamModel> Teams { get; set; } = new ObservableCollection<TeamModel>();

        public ICommand NewTeamAddedCommand { get; set; }

        public void Load()
        {
            Teams.Clear();

            foreach (var team in _teamsRepository.GetAll()) Teams.Add(team);
        }


        public void AddNewTeam()
        {
            _teamsRepository.Add(NewTeam);
            NewTeam.Name = "";

            Load();
        }

        private bool CanAddNewTeam()
        {
            return NewTeam != null
                   && !string.IsNullOrWhiteSpace(NewTeam.Name);
        }
    }
}