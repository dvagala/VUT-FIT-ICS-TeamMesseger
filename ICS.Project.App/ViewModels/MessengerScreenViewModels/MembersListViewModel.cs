using System.Collections.ObjectModel;
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
        private readonly IMediator _mediator;

        public UserModel NewMember { get; set; }

        public ObservableCollection<UserModel> Members { get; set; } = new ObservableCollection<UserModel>();


        public ICommand RemoveMemberCommand { get; set; }
        public ICommand MemberClickedCommand { get; set; }


        public MembersListViewModel(IUsersRepository usersRepository, IMediator mediator)
        {
//            NewMemberAddedCommand = new RelayCommand(AddNewTeam, CanAddNewTeam);
//            MemberClickedCommand = new RelayCommand<UserModel>(MemberClicked);
            MemberClickedCommand = new RelayCommand(MemberClicked);
            RemoveMemberCommand = new RelayCommand<UserModel>(RemoveMember);

            _mediator = mediator;
            _usersRepository = usersRepository;

            NewMember = new UserModel();
        }

        public void Load()
        {
            Members.Clear();
            foreach (var user in _usersRepository.GetAll()) Members.Add(user);
        }


        public void AddNewTeam()
        {
            _usersRepository.Add(NewMember);
            NewMember = new UserModel();
            Load();
        }

        private bool CanAddNewMember()
        {
            return NewMember != null && !string.IsNullOrWhiteSpace(NewMember.Name);
        }

        private void RemoveMember(UserModel clickedUser)
        {
            MessageBox.Show($"Member removed, {clickedUser.Name}");
        }


        private void MemberClicked()
        {
            MessageBox.Show("clicked");
        }

//        private void MemberClicked(UserModel clickedUser)
//        {
////            _mediator.Send(new SelectedTeamMessage{ Team= selectedTeamModel});
//            MessageBox.Show("clicked");
//        }


    }
}