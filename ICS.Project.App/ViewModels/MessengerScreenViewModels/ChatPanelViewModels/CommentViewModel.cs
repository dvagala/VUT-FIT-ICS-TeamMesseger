using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.BL.Models;

namespace ICS.Project.App.ViewModels.MessengerScreenViewModels.ChatPanelViewModels
{
    public class CommentViewModel : ViewModelBase, IViewModel
    {
        public CommentModel Comment { get; set; }
        public UserInitialsCircleViewModel NewCommentUserInitialsCircleViewModel { get; set; }

        public void Load()
        {
        }
    }
}