using System.Collections.ObjectModel;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels.MessengerScreenViewModels.ChatPanelViewModels
{
    public class PostViewModel : ViewModelBase, IViewModel
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IMediator _mediator;

        public ObservableCollection<PostModel> Posts { get; set; } = new ObservableCollection<PostModel>();



        public PostModel Post { get; set; }


        public PostViewModel()
        {

        }

        public void Load()
        {
        }
    }
}