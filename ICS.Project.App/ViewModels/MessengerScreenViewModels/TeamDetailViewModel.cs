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
    public class TeamDetailViewModel : ViewModelBase, IViewModel
    {
        private readonly ITeamsRepository _teamsRepository;
        private readonly IUsersRepository _usersRepository;

        public TeamDetailViewModel(IUsersRepository usersRepository, ITeamsRepository teamsRepository)
        {
            MemberClickedCommand = new RelayCommand<UserModel>(MemberClicked);
            RemoveMemberCommand = new RelayCommand<UserModel>(RemoveMember);
            AddNewMemberCommand = new RelayCommand(AddNewTeamMember, CanAddNewMember);
            DeleteTeamCommand = new RelayCommand(DeleteTeam);
            EditDescriptionCommand = new RelayCommand(EditDescription);
            SaveDescriptionCommand = new RelayCommand(SaveDescription, CanSaveDescription);

            _usersRepository = usersRepository;
            _teamsRepository = teamsRepository;

            Mediator.Instance.Register<SelectedTeamMessage>(TeamSelected);
            Mediator.Instance.Register<UserLoggedMessage>(UserLogged);
            Mediator.Instance.Register<UserLogoutMessage>(UserLogout);
        }

        public ICommand EditDescriptionCommand { get; set; }
        public ICommand SaveDescriptionCommand { get; set; }
        public ICommand MemberClickedCommand { get; set; }
        public ICommand RemoveMemberCommand { get; set; }
        public ICommand AddNewMemberCommand { get; set; }
        public ICommand DeleteTeamCommand { get; set; }

        public bool IsDescriptionInEditMode { get; set; }
        public UserModel SelectedUserInComboBox { get; set; }
        public ObservableCollection<UserModel> Members { get; set; } = new ObservableCollection<UserModel>();
        public ObservableCollection<UserModel> AvailableMembers { get; set; } = new ObservableCollection<UserModel>();
        public TeamModel Team { get; set; }
        public UserModel LoggedUser { get; set; }

        public void Load()
        {
            IsDescriptionInEditMode = false;
        }


        private void MemberClicked(UserModel clickedMember)
        {
            Mediator.Instance.Send(new UserWasClickedMessage {User = clickedMember});
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
            IsDescriptionInEditMode = false;

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
                foreach (var member in _teamsRepository.GetTeamMembers(Team.ID)) Members.Add(member);

                AvailableMembers.Clear();
                foreach (var member in _usersRepository.GetAll().Where(s => !Members.Select(e => e.ID).Contains(s.ID)))
                    AvailableMembers.Add(member);

                SelectedUserInComboBox = AvailableMembers.FirstOrDefault();
            }
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

        private async void RemoveMember(UserModel clickedUser)
        {
            object dialogResult;
            if (clickedUser.ID == LoggedUser.ID)
            {
                if (Members.Count() == 1)
                    dialogResult = await MaterialDesignThemes.Wpf.DialogHost.Show("You are the last member of this team. The team with all posts will be discarded if you leave! Are you sure to continue?", "YesOrNoDialogHost");
                else
                    dialogResult = await MaterialDesignThemes.Wpf.DialogHost.Show("Are you sure to remove yourself from this team? All your posts will reamain, but you lose access to the team!", "YesOrNoDialogHost");
            }
            else
            {
                dialogResult = await MaterialDesignThemes.Wpf.DialogHost.Show($"Are you sure to cancel {clickedUser.FullName} access to this team? All posts from the user will reamain.", "YesOrNoDialogHost");
            }

            if (dialogResult == null || dialogResult.ToString() == "No") return;

            _teamsRepository.RemoveUserFromTeam(clickedUser.ID, Team.ID);

            if (clickedUser.ID == LoggedUser.ID)
            {
                if (Members.Count() == 1) _teamsRepository.RemoveWithAllPostsAndComments(Team.ID);
                Mediator.Instance.Send(new UserLostAccessToTeam {Team = Team});
            }
            else
            {
                Members.Remove(clickedUser);
                AvailableMembers.Add(clickedUser);
                SelectedUserInComboBox = AvailableMembers.FirstOrDefault();
            }
        }

        private async void DeleteTeam()
        {
            object dialogResult = await MaterialDesignThemes.Wpf.DialogHost.Show($"Team {Team.Name} with all posts will be deleted! Are you sure to continue?", "YesOrNoDialogHost");

            if(dialogResult == null || dialogResult.ToString() == "No") return;

            _teamsRepository.RemoveWithAllPostsAndComments(Team.ID);
            Mediator.Instance.Send(new UserLostAccessToTeam {Team = Team});
        }


        public void EditDescription()
        {
            IsDescriptionInEditMode = true;
        }

        public void SaveDescription()
        {
            _teamsRepository.Update(Team);
            IsDescriptionInEditMode = false;
        }

        private bool CanSaveDescription()
        {
            return Team != null && !string.IsNullOrWhiteSpace(Team.Description);
        }
    }
}