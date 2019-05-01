using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
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
        private readonly IPostsRepository _postsRepository;
        private readonly ICommentsRepository _commentsRepository;
        private readonly IMediator _mediator;

        public ObservableCollection<PostViewModel> PostViewModels { get; set; } = new ObservableCollection<PostViewModel>();
        public PostViewModel NewPostViewModel { get; set; }
        public TeamModel Team { get; set; }
        public UserModel LoggedUser { get; set; }

        public ICommand AddNewPostCommand { get; set; }


        public ChatViewModel(ITeamsRepository teamsRepository, IPostsRepository postsRepository, ICommentsRepository commentsRepository, IMediator mediator)
        {
            _teamsRepository = teamsRepository;
            _postsRepository = postsRepository;
            _commentsRepository = commentsRepository;
            _mediator = mediator;

            _mediator.Register<SelectedTeamMessage>(TeamSelected);
            _mediator.Register<UserLoggedMessage>(UserLogged);

            AddNewPostCommand = new RelayCommand(AddNewPost, CanAddNewPost);

            NewPostViewModel = new PostViewModel(_commentsRepository, _mediator) { Post = new PostModel() };

        }

        public bool CanAddNewPost()
        {
            return !string.IsNullOrEmpty(NewPostViewModel.Post.Title) &&
                   !string.IsNullOrEmpty(NewPostViewModel.Post.MessageText);
        }

        public void AddNewPost()
        {
            _postsRepository.Add(NewPostViewModel.Post);
            NewPostViewModel = new PostViewModel(_commentsRepository, _mediator){ Post = new PostModel{ TeamId = Team.ID, AuthorId = LoggedUser.ID, Author = LoggedUser}};
            Refresh();
        }

        private void UserLogged(UserLoggedMessage userLoggedMessage)
        {
            LoggedUser = userLoggedMessage.User;

            NewPostViewModel = new PostViewModel(_commentsRepository, _mediator) { Post = new PostModel{ TeamId = Team.ID, Author = LoggedUser, AuthorId = LoggedUser.ID}};
//
//            NewPostViewModel.Post.Author = LoggedUser;
//            NewPostViewModel.Post.AuthorId = LoggedUser.ID;
        }

        private void TeamSelected(SelectedTeamMessage selectedTeamMessage)
        {
            Team = selectedTeamMessage.Team;
            NewPostViewModel.Post.TeamId = Team.ID;
            Refresh();
        }

        public void Refresh()
        {
            PostViewModels.Clear();
            IList<PostModel> posts = _teamsRepository.GetPostsWithCommentsAndAuthors(Team.ID);

            // Sort here
            foreach (var post in posts)
            {
                PostViewModels.Add(new PostViewModel(_commentsRepository, _mediator) { Post = post, LoggedUser = LoggedUser});
            }
        }

        public void Load()
        {
        }
    }
}