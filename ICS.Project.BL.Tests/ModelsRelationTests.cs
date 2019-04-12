using System.Linq;
using ICS.Project.BL.Models;
using Xunit;

namespace ICS.Project.BL.Tests
{
    public class ModelsRelationTests : IClassFixture<RepositoryLayerTestsFixture>
    {
        public ModelsRelationTests(RepositoryLayerTestsFixture fixture)
        {
            _fixture = fixture;
        }

        private readonly RepositoryLayerTestsFixture _fixture;

        [Fact]
        public void AddPostWithAuthor_ReturnCorrectRelation()
        {
            var userModel = new UserModel
            {
                Name = "Ignac"
            };

            userModel = _fixture.UsersRepository.Add(userModel);


            var postModel = new PostModel
            {
                Title = "Whoo",
                AutorId = userModel.ID
            };

            postModel = _fixture.PostsRepository.Add(postModel);

            var retrievedPostModel = _fixture.PostsRepository.GetAll().FirstOrDefault();

            var retrievedPostAuthor = _fixture.PostsRepository.GetAuthorOfPost(retrievedPostModel.ID);

            Assert.Equal("Ignac", retrievedPostAuthor.Name);

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void AddUsersToTeam_GetTeamMembers()
        {
            var userModel1 = new UserModel
            {
                Name = "Mike"
            };

            var userModel2 = new UserModel
            {
                Name = "Pete"
            };

            var userModel3 = new UserModel
            {
                Name = "Lez"
            };

            userModel1 = _fixture.UsersRepository.Add(userModel1);
            userModel2 = _fixture.UsersRepository.Add(userModel2);
            userModel3 = _fixture.UsersRepository.Add(userModel3);

            var teamModel = new TeamModel
            {
                Name = "Team name"
            };

            teamModel = _fixture.TeamsRepository.Add(teamModel);

            _fixture.TeamsRepository.AddUserToTeam(userModel1.ID, teamModel.ID);
            _fixture.TeamsRepository.AddUserToTeam(userModel2.ID, teamModel.ID);
            _fixture.TeamsRepository.AddUserToTeam(userModel3.ID, teamModel.ID);

            var retrievedUsers = _fixture.TeamsRepository.GetTeamMembers(teamModel.ID);

            Assert.Equal(userModel1.ID, retrievedUsers.ElementAt(0).ID);
            Assert.Equal(userModel2.ID, retrievedUsers.ElementAt(1).ID);
            Assert.Equal(userModel3.ID, retrievedUsers.ElementAt(2).ID);

            Assert.Equal("Mike", retrievedUsers.ElementAt(0).Name);
            Assert.Equal("Pete", retrievedUsers.ElementAt(1).Name);
            Assert.Equal("Lez", retrievedUsers.ElementAt(2).Name);

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }


        [Fact]
        public void AddUserToTeams_GetUserTeams()
        {
            var userModel = new UserModel
            {
                Name = "Mike"
            };

            userModel = _fixture.UsersRepository.Add(userModel);

            var teamModel1 = new TeamModel
            {
                Name = "Team1"
            };

            var teamModel2 = new TeamModel
            {
                Name = "Team2"
            };

            var teamModel3 = new TeamModel
            {
                Name = "Team3"
            };

            teamModel1 = _fixture.TeamsRepository.Add(teamModel1);
            teamModel2 = _fixture.TeamsRepository.Add(teamModel2);
            teamModel3 = _fixture.TeamsRepository.Add(teamModel3);

            _fixture.TeamsRepository.AddUserToTeam(userModel.ID, teamModel1.ID);
            _fixture.TeamsRepository.AddUserToTeam(userModel.ID, teamModel2.ID);
            _fixture.TeamsRepository.AddUserToTeam(userModel.ID, teamModel3.ID);

            var retrievedTeams = _fixture.UsersRepository.GetUserTeams(userModel.ID);

            Assert.Equal(teamModel1.ID, retrievedTeams.ElementAt(0).ID);
            Assert.Equal(teamModel2.ID, retrievedTeams.ElementAt(1).ID);
            Assert.Equal(teamModel3.ID, retrievedTeams.ElementAt(2).ID);

            Assert.Equal("Team1", retrievedTeams.ElementAt(0).Name);
            Assert.Equal("Team2", retrievedTeams.ElementAt(1).Name);
            Assert.Equal("Team3", retrievedTeams.ElementAt(2).Name);

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void RemoveAllUserFromTeam_GetNoTeamMembers()
        {
            var userModel1 = new UserModel
            {
                Name = "Mike"
            };

            var userModel2 = new UserModel
            {
                Name = "Pete"
            };

            var userModel3 = new UserModel
            {
                Name = "Lez"
            };

            userModel1 = _fixture.UsersRepository.Add(userModel1);
            userModel2 = _fixture.UsersRepository.Add(userModel2);
            userModel3 = _fixture.UsersRepository.Add(userModel3);

            var teamModel = new TeamModel
            {
                Name = "Team name"
            };

            teamModel = _fixture.TeamsRepository.Add(teamModel);

            _fixture.TeamsRepository.AddUserToTeam(userModel1.ID, teamModel.ID);
            _fixture.TeamsRepository.AddUserToTeam(userModel2.ID, teamModel.ID);
            _fixture.TeamsRepository.AddUserToTeam(userModel3.ID, teamModel.ID);

            _fixture.TeamsRepository.RemoveUserFromTeam(userModel1.ID, teamModel.ID);
            _fixture.TeamsRepository.RemoveUserFromTeam(userModel2.ID, teamModel.ID);
            _fixture.TeamsRepository.RemoveUserFromTeam(userModel3.ID, teamModel.ID);

            var retrievedUsers = _fixture.TeamsRepository.GetTeamMembers(teamModel.ID);

            Assert.False(retrievedUsers.Any());

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void RemoveUserFromTeam_GetTeamMembers()
        {
            var userModel1 = new UserModel
            {
                Name = "Mike"
            };

            var userModel2 = new UserModel
            {
                Name = "Pete"
            };

            var userModel3 = new UserModel
            {
                Name = "Lez"
            };

            userModel1 = _fixture.UsersRepository.Add(userModel1);
            userModel2 = _fixture.UsersRepository.Add(userModel2);
            userModel3 = _fixture.UsersRepository.Add(userModel3);

            var teamModel = new TeamModel
            {
                Name = "Team name"
            };

            teamModel = _fixture.TeamsRepository.Add(teamModel);

            _fixture.TeamsRepository.AddUserToTeam(userModel1.ID, teamModel.ID);
            _fixture.TeamsRepository.AddUserToTeam(userModel2.ID, teamModel.ID);
            _fixture.TeamsRepository.AddUserToTeam(userModel3.ID, teamModel.ID);

            _fixture.TeamsRepository.RemoveUserFromTeam(userModel3.ID, teamModel.ID);

            var retrievedUsers = _fixture.TeamsRepository.GetTeamMembers(teamModel.ID);

            Assert.Equal(userModel1.ID, retrievedUsers.ElementAt(0).ID);
            Assert.Equal(userModel2.ID, retrievedUsers.ElementAt(1).ID);

            Assert.Equal("Mike", retrievedUsers.ElementAt(0).Name);
            Assert.Equal("Pete", retrievedUsers.ElementAt(1).Name);

            Assert.Equal(2, retrievedUsers.ToList().Count);

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void UpdateUserName_ReturnCorrectName()
        {
            var userModel = new UserModel
            {
                Name = "Old name"
            };

            userModel = _fixture.UsersRepository.Add(userModel);

            var retrievedUser = _fixture.UsersRepository.GetAll().FirstOrDefault();

            retrievedUser.Name = "New name";

            _fixture.UsersRepository.Update(retrievedUser);

            var retrievedUserWithNewName = _fixture.UsersRepository.GetAll().FirstOrDefault();

            Assert.Equal("New name", retrievedUserWithNewName.Name);

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }
    }
}