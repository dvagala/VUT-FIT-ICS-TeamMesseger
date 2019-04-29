using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels.MessengerScreenViewModels
{
    public class TeamDetailViewModel : ViewModelBase, IViewModel
    {
        private readonly ITeamsRepository _teamsRepository;
        private readonly IMediator _mediator;

        public bool IsDescriptionInEditMode { get; set; } = false;
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