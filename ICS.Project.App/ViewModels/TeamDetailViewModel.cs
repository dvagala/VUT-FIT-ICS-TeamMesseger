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

        private bool _isDescriptionInEditMode;
        public bool IsDescriptionInEditMode
        {
            get => _isDescriptionInEditMode;
            set
            {
                _isDescriptionInEditMode = value;
                OnPropertyChanged();
            }
        }


        public TeamModel Team { get; set; }


        public ICommand EditDescriptionCommand { get; set; }
        public ICommand SaveDescriptionCommand { get; set; }


        public TeamDetailViewModel(ITeamsRepository teamsRepository, IMediator mediator)
        {
            EditDescriptionCommand = new RelayCommand(EditDescription);
            SaveDescriptionCommand = new RelayCommand(SaveDescription, CanSaveDescription);

            _mediator = mediator;
            _teamsRepository = teamsRepository;
            _mediator.Register<SelectedTeamMessage>(TeamSelected);

            Team = _teamsRepository.GetFirst();
            IsDescriptionInEditMode = false;
        }

        public void Load()
        {
            IsDescriptionInEditMode = false;
        }

        public void EditDescription()
        {
            IsDescriptionInEditMode = true;
        }

        public void SaveDescription()
        {
            _teamsRepository.Update(Team);
            IsDescriptionInEditMode = false;
        }

        private bool CanSaveDescription()
        {
            return Team != null && !string.IsNullOrWhiteSpace(Team.Description);
        }

        private void TeamSelected( SelectedTeamMessage selectedTeamMessage)
        {            
            Team = _teamsRepository.GetById(selectedTeamMessage.Id);
            IsDescriptionInEditMode = false;
        }
    }
}