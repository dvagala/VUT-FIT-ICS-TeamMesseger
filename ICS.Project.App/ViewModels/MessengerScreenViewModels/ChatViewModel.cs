using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.App.ViewModels.MessengerScreenViewModels.ChatPanelViewModels;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels.MessengerScreenViewModels
{
    public class ChatViewModel : ViewModelBase, IViewModel
    {
        private readonly ITeamsRepository _teamsRepository;
        private readonly IMediator _mediator;

        public ObservableCollection<PostViewModel> PostViewModels { get; set; } = new ObservableCollection<PostViewModel>();
        public TeamModel Team { get; set; }

        public ChatViewModel(ITeamsRepository teamsRepository, IMediator mediator)
        {
            _teamsRepository = teamsRepository;
            _mediator = mediator;
            _mediator.Register<SelectedTeamMessage>(TeamSelected);
        }

        private void TeamSelected(SelectedTeamMessage selectedTeamMessage)
        {
            PostViewModels.Clear();
            Team = _teamsRepository.GetById(selectedTeamMessage.Id);
            IList<PostModel> postsInTeam = _teamsRepository.GetPosts(Team.ID);

            foreach (var postModel in postsInTeam)
            {
                PostViewModels.Add(new PostViewModel{ Post = postModel});
            }
        }

        public void Load()
        {
        }
    }
}