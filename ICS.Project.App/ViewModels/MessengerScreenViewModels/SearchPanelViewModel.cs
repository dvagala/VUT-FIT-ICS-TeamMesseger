using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Models;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels.MessengerScreenViewModels
{
    public class SearchPanelViewModel : ViewModelBase, IViewModel
    {
        private string _searchedText;

        public SearchPanelViewModel()
        {
            Mediator.Instance.Register<SelectedTeamMessage>(TeamSelected);
        }

        public TeamModel Team { get; set; }

        public string SearchedText
        {
            get => _searchedText;
            set
            {
                _searchedText = value;
                Mediator.Instance.Send(new UserWantsToSearchText {SearchedText = _searchedText});
            }
        }

        public void Load()
        {
        }

        private void TeamSelected(SelectedTeamMessage selectedTeamMessage)
        {
            SearchedText = "";
            Team = selectedTeamMessage.Team;
            Mediator.Instance.Send(new UserWantsToSearchText {SearchedText = SearchedText});
        }
    }
}