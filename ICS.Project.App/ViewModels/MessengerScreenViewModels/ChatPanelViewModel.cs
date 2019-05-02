using System;
using System.Collections.ObjectModel;
using System.Linq;
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
    public class ChatPanelViewModel : ViewModelBase, IViewModel
    {
        private readonly ITeamsRepository _teamsRepository;
        private readonly IPostsRepository _postsRepository;
        private readonly ICommentsRepository _commentsRepository;
        private readonly IMediator _mediator;

        public ObservableCollection<PostViewModel> PostViewModels { get; set; } =
            new ObservableCollection<PostViewModel>();

        public PostModel NewPost { get; set; }
        public UserInitialsCircleViewModel NewPostUserInitialsCircleViewModel { get; set; }

        public TeamModel Team { get; set; }
        public UserModel LoggedUser { get; set; }

        public ICommand AddNewPostCommand { get; set; }


        public ChatPanelViewModel(ITeamsRepository teamsRepository, IPostsRepository postsRepository,
            ICommentsRepository commentsRepository, IMediator mediator)
        {
            _teamsRepository = teamsRepository;
            _postsRepository = postsRepository;
            _commentsRepository = commentsRepository;
            _mediator = mediator;

            _mediator.Register<SelectedTeamMessage>(TeamSelected);
            _mediator.Register<UserLoggedMessage>(UserLogged);
            _mediator.Register<UserLogoutMessage>(UserLogout);
            _mediator.Register<UserWantsToSearchText>(FilterPostViewModels);

            AddNewPostCommand = new RelayCommand(AddNewPost, CanAddNewPost);
        }


        public void FilterPostViewModels(UserWantsToSearchText userWantsToSearchText)
        {
            var searchedText = userWantsToSearchText.SearchedText;

            if (!string.IsNullOrEmpty(searchedText))
            {
                PostViewModels.Clear();
                var posts = _teamsRepository.GetPostsWithCommentsAndAuthors(Team.ID);

                // Sort here
                foreach (var post in posts)
                    if (post.MessageText.Contains(searchedText) || post.Author.FullName.Contains(searchedText) ||
                        post.Title.Contains(searchedText) || post.Comments.Any(s => s.MessageText.Contains(searchedText) || s.Author.FullName.Contains(searchedText)))
                        PostViewModels.Add(new PostViewModel(_commentsRepository, _mediator, post, LoggedUser));
            }
            else
            {
                if (Team != null) Refresh();
            }
        }

        public bool CanAddNewPost()
        {
            return !string.IsNullOrEmpty(NewPost?.Title) &&
                   !string.IsNullOrEmpty(NewPost?.MessageText);
        }

        public void AddNewPost()
        {
            NewPost.PublishDate = DateTime.Now;
            _postsRepository.Add(NewPost);
            NewPost = new PostModel {TeamId = Team.ID, AuthorId = LoggedUser.ID, Author = LoggedUser};

            Refresh();
        }

        private void UserLogged(UserLoggedMessage userLoggedMessage)
        {
            LoggedUser = userLoggedMessage.User;

            NewPost = new PostModel
            {
                Author = LoggedUser,
                AuthorId = LoggedUser.ID
            };
            NewPostUserInitialsCircleViewModel = new UserInitialsCircleViewModel {User = LoggedUser};
        }

        private void UserLogout(UserLogoutMessage userLoggedMessage)
        {
            LoggedUser = null;
            Team = null;
            NewPost = null;
            PostViewModels.Clear();
            NewPostUserInitialsCircleViewModel = null;
        }

        private void TeamSelected(SelectedTeamMessage selectedTeamMessage)
        {
            if (selectedTeamMessage.Team == null)
            {
                Team = null;
                PostViewModels.Clear();
            }
            else
            {
                Team = selectedTeamMessage.Team;
                NewPost.TeamId = Team.ID;
                Refresh();
            }
        }

        public void Refresh()
        {
            PostViewModels.Clear();
            var posts = _teamsRepository.GetPostsWithCommentsAndAuthors(Team.ID);

            // Sort here
            foreach (var post in posts)
                PostViewModels.Add(new PostViewModel(_commentsRepository, _mediator, post, LoggedUser));
        }

        public void Load()
        {
        }
    }
}