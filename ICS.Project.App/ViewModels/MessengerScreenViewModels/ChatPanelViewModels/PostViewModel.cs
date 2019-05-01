using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public CommentViewModel NewCommentViewModel { get; set; }

        public PostModel Post { get; set; }
        public UserModel LoggedUser { get; set; }


        public PostViewModel( ICommentsRepository commentsRepository, IMediator mediator)
        {
            _commentsRepository = commentsRepository;
            _mediator = mediator;

            AddNewCommentCommand = new RelayCommand(AddNewComment, CanAddNewComment);


        }

        public bool CanAddNewComment()
        {
            return !string.IsNullOrEmpty(NewCommentViewModel.Comment.MessageText);
        }

        public void AddNewComment()
        {
            _commentsRepository.Add(NewCommentViewModel.Comment);
            NewCommentViewModel = new CommentViewModel{ Comment = new CommentModel { PostId = Post.ID, Author = LoggedUser, AuthorId = LoggedUser.ID } };
            Refresh();
        }


        public void Load()
        {
            NewCommentViewModel = new CommentViewModel { Comment = new CommentModel { PostId = Post.ID, Author = LoggedUser, AuthorId = LoggedUser.ID } };

            Refresh();
        }

        public void Refresh()
        {
            CommentViewModels.Clear();

            if (Post.Comments == null)
            {
                return;
            }

            // Sort here
            foreach (var comment in Post.Comments)
            {
                CommentViewModels.Add(new CommentViewModel { Comment = comment });
            }
        }
    }
}