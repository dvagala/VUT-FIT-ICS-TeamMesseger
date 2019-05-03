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
        private readonly ICommentsRepository _commentsRepository;
        private readonly IPostsRepository _postsRepository;
        private readonly ITeamsRepository _teamsRepository;
        private readonly IUsersRepository _usersRepository;

        public ChatPanelViewModel(ITeamsRepository teamsRepository, IPostsRepository postsRepository,
            ICommentsRepository commentsRepository, IUsersRepository usersRepository)
        {
            AddNewPostCommand = new RelayCommand(AddNewPost, CanAddNewPost);

            _teamsRepository = teamsRepository;
            _postsRepository = postsRepository;
            _commentsRepository = commentsRepository;
            _usersRepository = usersRepository;

            Mediator.Instance.Register<SelectedTeamMessage>(TeamSelected);
            Mediator.Instance.Register<UserLoggedMessage>(UserLogged);
            Mediator.Instance.Register<UserLogoutMessage>(UserLogout);
            Mediator.Instance.Register<UserWantsToSearchText>(FilterPostViewModels);
        }

        public ICommand AddNewPostCommand { get; set; }

        public ObservableCollection<PostViewModel> PostViewModels { get; set; } =
            new ObservableCollection<PostViewModel>();

        public PostModel NewPost { get; set; }
        public UserInitialsCircleViewModel NewPostUserInitialsCircleViewModel { get; set; }
        public TeamModel Team { get; set; }
        public UserModel LoggedUser { get; set; }

        public void Load()
        {
        }

        public void FilterPostViewModels(UserWantsToSearchText userWantsToSearchText)
        {
            var searchedText = userWantsToSearchText.SearchedText;

            if (!string.IsNullOrEmpty(searchedText))
            {
                PostViewModels.Clear();
                var posts = _teamsRepository.GetPostsWithCommentsAndAuthors(Team.ID);

                foreach (var post in posts.OrderByDescending(p =>
                    p.Comments.Any() ? p.Comments.Max(c => c.PublishDate) : p.PublishDate))
                    if (post.MessageText.Contains(searchedText) || post.Author.FullName.Contains(searchedText) ||
                        post.Title.Contains(searchedText) || post.Comments.Any(s =>
                            s.MessageText.Contains(searchedText) || s.Author.FullName.Contains(searchedText)))
                        PostViewModels.Add(new PostViewModel(_commentsRepository, post, LoggedUser));
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

        private void UserLogout(UserLogoutMessage userLogoutMessage)
        {
            LoggedUser.IsLoggedIn = false;
            LoggedUser.LastLogoutTime = DateTime.Now;
            _usersRepository.Update(LoggedUser);

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

            foreach (var post in posts.OrderByDescending(p =>
                p.Comments.Any() ? p.Comments.Max(c => c.PublishDate) : p.PublishDate))
                PostViewModels.Add(new PostViewModel(_commentsRepository, post, LoggedUser));
        }
    }
}