using System.Windows;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels.MessengerScreenViewModels
{
    public class SearchPanelViewModel : ViewModelBase, IViewModel
    {
        private readonly IMediator _mediator;

        public TeamModel Team { get; set; }

        private string _searchedText;
        public string SearchedText
        {
            get => _searchedText;
            set
            {
                _searchedText = value;
                _mediator.Send(new UserWantsToSearchText { SearchedText = _searchedText });
            }
        }

        public SearchPanelViewModel(IMediator mediator)
        {
            _mediator = mediator;
            _mediator.Register<SelectedTeamMessage>(TeamSelected);
        }

        private void TeamSelected(SelectedTeamMessage selectedTeamMessage)
        {
            SearchedText = "";
            Team = selectedTeamMessage.Team;
            _mediator.Send(new UserWantsToSearchText{SearchedText = SearchedText});
        }

        public void Load()
        {
        }
    }
}