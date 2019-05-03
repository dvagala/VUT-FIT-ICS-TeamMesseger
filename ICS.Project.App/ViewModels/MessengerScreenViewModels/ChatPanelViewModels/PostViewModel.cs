using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels.MessengerScreenViewModels.ChatPanelViewModels
{
    public class PostViewModel : ViewModelBase, IViewModel
    {
        private readonly ICommentsRepository _commentsRepository;
        private readonly IMediator _mediator;

        public ICommand AddNewCommentCommand { get; set; }

        public ObservableCollection<CommentViewModel> CommentViewModels { get; set; } = new ObservableCollection<CommentViewModel>();

        public CommentModel NewComment { get; set; }
        public UserInitialsCircleViewModel NewCommentUserInitialsCircleViewModel { get; set; }

        public PostModel Post { get; set; }
        public UserModel LoggedUser { get; set; }
        public UserInitialsCircleViewModel PostUserInitialsCircleViewModel { get; set; }


        public PostViewModel( ICommentsRepository commentsRepository, IMediator mediator, PostModel post, UserModel loggedUser)
        {
            _commentsRepository = commentsRepository;
            _mediator = mediator;

            Post = post;
            LoggedUser = loggedUser;
            PostUserInitialsCircleViewModel = new UserInitialsCircleViewModel { User = Post.Author };
            NewComment = new CommentModel{Author = LoggedUser, AuthorId = LoggedUser.ID, PostId = Post.ID};
            NewCommentUserInitialsCircleViewModel = new UserInitialsCircleViewModel { User = LoggedUser };

            AddNewCommentCommand = new RelayCommand(AddNewComment, CanAddNewComment);

            foreach (var comment in Post.Comments.OrderByDescending(s => s.PublishDate))
            {
                CommentViewModels.Add(new CommentViewModel { Comment = comment, NewCommentUserInitialsCircleViewModel = new UserInitialsCircleViewModel { User = comment.Author } });
            }
        }

        public bool CanAddNewComment()
        {
            return !string.IsNullOrEmpty(NewComment.MessageText);
        }

        public void AddNewComment()
        {
            NewComment.PublishDate = DateTime.Now;
            var commentFromDb = _commentsRepository.Add(NewComment);
            commentFromDb.Author = LoggedUser;
            CommentViewModels.Add(new CommentViewModel { Comment = commentFromDb, NewCommentUserInitialsCircleViewModel = new UserInitialsCircleViewModel { User = commentFromDb.Author } });
            NewComment = new CommentModel{Author = LoggedUser, AuthorId = LoggedUser.ID, PostId = Post.ID};
        }

        public void Load()
        {
        }
    }
}