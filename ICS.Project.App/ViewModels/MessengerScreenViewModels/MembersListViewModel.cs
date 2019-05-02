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

namespace ICS.Project.App.ViewModels.MessengerScreenViewModels
{
    public class MembersListViewModel : ViewModelBase, IViewModel
    {
        private readonly IUsersRepository _usersRepository;
        private readonly ITeamsRepository _teamsRepository;
        private readonly IMediator _mediator;

        public UserModel SelectedUserInComboBox { get; set; }

        public ObservableCollection<UserModel> Members { get; set; } = new ObservableCollection<UserModel>();
        public ObservableCollection<UserModel> AvailableMembers { get; set; } = new ObservableCollection<UserModel>();
        public TeamModel Team { get; set; }
        public UserModel LoggedUser { get; set; }


        public ICommand MemberClickedCommand { get; set; }
        public ICommand RemoveMemberCommand { get; set; }
        public ICommand AddNewMemberCommand { get; set; }


        public MembersListViewModel(IUsersRepository usersRepository, ITeamsRepository teamsRepository, IMediator mediator)
        {
            MemberClickedCommand = new RelayCommand(MemberClicked);
            RemoveMemberCommand = new RelayCommand<UserModel>(RemoveMember);
            AddNewMemberCommand = new RelayCommand(AddNewTeamMember, CanAddNewMember);

            _mediator = mediator;
            _usersRepository = usersRepository;
            _teamsRepository = teamsRepository;

            _mediator.Register<SelectedTeamMessage>(TeamSelected);
            _mediator.Register<UserLoggedMessage>(UserLogged);
            _mediator.Register<UserLogoutMessage>(UserLogout);
        }

        private void UserLogged(UserLoggedMessage userLoggedMessage)
        {
            LoggedUser = userLoggedMessage.User;
        }

        private void UserLogout(UserLogoutMessage userLoggedMessage)
        {
            LoggedUser = null;
        }

        private void TeamSelected(SelectedTeamMessage selectedTeamMessage)
        {

            if (selectedTeamMessage.Team == null)
            {
                Team = null;
                Members.Clear();
                AvailableMembers.Clear();
                SelectedUserInComboBox = null;
            }
            else
            {
                Team = selectedTeamMessage.Team;

                Members.Clear();
                foreach (var member in _usersRepository.GetTeamMembers(Team.ID))
                {
                    Members.Add(member);
                }

                AvailableMembers.Clear();
                foreach (var member in _usersRepository.GetAll().Where(s => !Members.Select(e => e.ID).Contains(s.ID)))
                {
                    AvailableMembers.Add(member);
                }

                SelectedUserInComboBox = AvailableMembers.FirstOrDefault();
            }
        }

        public void Load()
        {
            SelectedUserInComboBox = new UserModel();
        }

        public void AddNewTeamMember()
        {
            _teamsRepository.AddUserToTeam(SelectedUserInComboBox.ID, Team.ID);
            Members.Add(SelectedUserInComboBox);
            AvailableMembers.Remove(SelectedUserInComboBox);
            SelectedUserInComboBox = AvailableMembers.FirstOrDefault();
        }

        private bool CanAddNewMember()
        {
            return SelectedUserInComboBox != null;
        }

        private void RemoveMember(UserModel clickedUser)
        {
            MessageBoxResult messageBoxResult;
            if (clickedUser.ID == LoggedUser.ID)
            {
                if (Members.Count() == 1)
                {
                    messageBoxResult = MessageBox.Show("You are the last member of this team. The team with all posts will be discarded if you leave! Are you sure to continue?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);
                }
                else
                {
                    messageBoxResult = MessageBox.Show("Are you sure to remove yourself from this team? All your posts will reamain, but you lose access to the team!", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);
                }
            }
            else
            {
                messageBoxResult = MessageBox.Show($"Are you sure to cancel {clickedUser.FullName} access to this team? All posts from the user will reamain.", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);
            }

            if (messageBoxResult == MessageBoxResult.No) return;

            _teamsRepository.RemoveUserFromTeam(clickedUser.ID, Team.ID);

            if (clickedUser.ID == LoggedUser.ID)
            {
                _mediator.Send(new UserRemovedHimselfFromTeamMessage { Team = Team });
            }
            else
            {
                Members.Remove(clickedUser);
                AvailableMembers.Add(clickedUser);
                SelectedUserInComboBox = AvailableMembers.FirstOrDefault();
            }
        }

        private void MemberClicked()
        {
            MessageBox.Show("Todo show user detail");
        }
    }
}