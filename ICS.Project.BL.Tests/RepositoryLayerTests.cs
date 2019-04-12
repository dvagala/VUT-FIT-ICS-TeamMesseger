using ICS.Project.BL.Models;
using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace ICS.Project.BL.Tests
{
    public class RepositoryLayerTests : IClassFixture<RepositoryLayerTestsFixture>
    {
        public RepositoryLayerTests(RepositoryLayerTestsFixture fixture)
        {
            _fixture = fixture;
        }

        private readonly RepositoryLayerTestsFixture _fixture;

        [Fact]
        public void AddUser_GetByIdCorrectUser()
        {
            var userModel = new UserModel
            {
                Name = "Ignac"
            };

            userModel = _fixture.UsersRepository.Add(userModel);

            var retrievedUser = _fixture.UsersRepository.GetById(userModel.ID);

            Assert.Equal("Ignac", retrievedUser.Name);

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void AddUser_ReturnCorrectName()
        {
            var userModel = new UserModel
            {
                Name = "Ignac"
            };

            userModel = _fixture.UsersRepository.Add(userModel);

            Assert.Equal("Ignac", userModel.Name);

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }
    }
}