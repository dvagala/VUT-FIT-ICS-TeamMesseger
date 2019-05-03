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
        private readonly IUsersRepository _usersRepository;
        public UserModel User { get; set; }

        public IList<TeamModel> Teams { get; set; }


        public UserDetailScreenViewModel(ITeamsRepository teamsRepository, IUsersRepository usersRepository)
        {
            _teamsRepository = teamsRepository;
            _usersRepository = usersRepository;

            Mediator.Instance.Register<UserWasClickedMessage>(UserWasClicked);
        }

        public void Load()
        {
        }

        public void UserWasClicked(UserWasClickedMessage userWasClickedMessage)
        {
            User = _usersRepository.GetById(userWasClickedMessage.User.ID);     // Just to get fresh data
            Teams = _teamsRepository.GetUserTeams(User.ID).ToList();
        }
    }
}