using System.Collections.Generic;
using System.Collections.ObjectModel;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels.MessengerScreenViewModels.ChatPanelViewModels
{
    public class CommentViewModel : ViewModelBase, IViewModel
    {

        public CommentModel Comment { get; set; }

        public UserInitialsCircleViewModel NewCommentUserInitialsCircleViewModel { get; set; }


        public CommentViewModel()
        {
        }

        public void Load()
        {
        }
    }
}