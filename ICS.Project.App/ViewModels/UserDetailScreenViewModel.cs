using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using ICS.Project.App.Commands;
using ICS.Project.App.ViewModels.BaseViewModels;
using ICS.Project.BL.Messages;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using ICS.Project.BL.Services;

namespace ICS.Project.App.ViewModels
{
    public class UserDetailScreenViewModel : ViewModelBase, IViewModel
    {
        private readonly ITeamsRepository _teamsRepository;
        public UserModel User { get; set; }

        public IList<TeamModel> Teams { get; set; }


        public UserDetailScreenViewModel(ITeamsRepository teamsRepository)
        {
            _teamsRepository = teamsRepository;

            Mediator.Instance.Register<UserWasClickedMessage>(UserWasClicked);
        }

        public void Load()
        {
        }

        public void UserWasClicked(UserWasClickedMessage userWasClickedMessage)
        {
            User = userWasClickedMessage.User;
            Teams = _teamsRepository.GetUserTeams(User.ID).ToList();
        }
    }
}