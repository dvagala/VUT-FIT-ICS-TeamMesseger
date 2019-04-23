using System.Collections.ObjectModel;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;

namespace ICS.Project.App.ViewModels
{
    public class TeamDetailViewModel : ViewModelBase, IViewModel
    {
        private readonly ITeamsRepository _teamsRepository;

        public TeamModel NewTeam { get; set; } = new TeamModel();

        public ICommand EditDescriptionCommand { get; set; }

        public TeamDetailViewModel(ITeamsRepository teamsRepository)
        {
            EditDescriptionCommand = new RelayCommand(SaveDescription, CanSaveDescription);

            _teamsRepository = teamsRepository;
        }

        public void Load()
        {
        }


        public void SaveDescription()
        {
            Load();
        }

        private bool CanSaveDescription()
        {
            return true;
        }
    }
}