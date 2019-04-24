using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels
{
    public class TeamDetailViewModel : ViewModelBase, IViewModel
    {
        private readonly ITeamsRepository _teamsRepository;
        private readonly IMediator _mediator;


        private TeamModel _team;
        public TeamModel Team
        {
            get => _team;
            set
            {
                _team = value;
                OnPropertyChanged();
            }
        }


        public ICommand EditDescriptionCommand { get; set; }


        public TeamDetailViewModel(ITeamsRepository teamsRepository, IMediator mediator)
        {
            EditDescriptionCommand = new RelayCommand(SaveDescription, CanSaveDescription);

            _mediator = mediator;
            _teamsRepository = teamsRepository;
            _mediator.Register<SelectedTeamMessage>(TeamSelected);

            Team = _teamsRepository.GetFirst();

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

        private void TeamSelected( SelectedTeamMessage selectedTeamMessage)
        {            
            Team = _teamsRepository.GetById(selectedTeamMessage.Id);
        }
    }
}