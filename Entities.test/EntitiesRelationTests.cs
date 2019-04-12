using System.Linq;
using ICS.Project.DAL.Entities;
using ICS.Project.DAL.Tests;
using Xunit;

namespace ICS.Project.DAL.Tests
{
    public class EntitiesRelationTests : IClassFixture<EntitiesTestsFixture>
    {
        private readonly EntitiesTestsFixture _fixture;

        public EntitiesRelationTests(EntitiesTestsFixture fixture)
        {
            this._fixture = fixture;
        }

        [Fact]
        public void AddPostWithUser_ReturnCorrectRelation()
        {
            var userEntity = new UserEntity
            {
                Name = "Michael"
            };

            using (var dbContextLoc = _fixture.CreateMessengerDbContext())
            {
                dbContextLoc.Users.Add(userEntity);
                dbContextLoc.SaveChanges();
            }

            var postEntity = new PostEntity
            {
                Title = "Post title",
                AuthorId = userEntity.ID
            };

            using (var dbContextLoc = _fixture.CreateMessengerDbContext())
            {
                dbContextLoc.Posts.Add(postEntity);
                dbContextLoc.SaveChanges();
            }

            var retrievedUser = _fixture.MessengerDbContextSUT
                .Users
                .FirstOrDefault();

            var retrievedPost = _fixture.MessengerDbContextSUT
                .Posts
                .FirstOrDefault();

            Assert.Equal(retrievedPost.AuthorId, retrievedUser.ID);
            Assert.Equal("Michael", retrievedUser.Name);
            Assert.Equal("Post title", retrievedPost.Title);

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void AddCommentWithUser_ReturnCorrectRelation()
        {
            
            

            var userEntity = new UserEntity
            {
                Name = "Andy"
            };

            using (var dbContextLoc = _fixture.CreateMessengerDbContext())
            {
                dbContextLoc.Users.Add(userEntity);
                dbContextLoc.SaveChanges();
            }

            var commentEntity = new CommentEntity
            {
                MessageText = "Comment text",
                AuthorId = userEntity.ID
            };

            using (var dbContextLoc = _fixture.CreateMessengerDbContext())
            {
                dbContextLoc.Comments.Add(commentEntity);
                dbContextLoc.SaveChanges();
            }

            var retrievedUser = _fixture.MessengerDbContextSUT
                .Users
                .FirstOrDefault();

            var retrievedComment = _fixture.MessengerDbContextSUT
                .Comments
                .FirstOrDefault();

            Assert.Equal(retrievedComment.AuthorId, retrievedUser.ID);
            Assert.Equal("Andy", retrievedUser.Name);
            Assert.Equal("Comment text", retrievedComment.MessageText);

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void AddPostWithComment_ReturnCorrectRelation()
        {
            
            

            var postEntity = new PostEntity
            {
                Title = "Post title"
            };

            using (var dbContextLoc = _fixture.CreateMessengerDbContext())
            {
                dbContextLoc.Posts.Add(postEntity);
                dbContextLoc.SaveChanges();
            }

            var commentEntity = new CommentEntity
            {
                MessageText = "Comment text",
                PostId = postEntity.ID
            };

            using (var dbContextLoc = _fixture.CreateMessengerDbContext())
            {
                dbContextLoc.Comments.Add(commentEntity);
                dbContextLoc.SaveChanges();
            }

            var retrievedComment = _fixture.MessengerDbContextSUT
                .Comments
                .FirstOrDefault();

            var retrievedPost = _fixture.MessengerDbContextSUT
                .Posts
                .FirstOrDefault();

            Assert.Equal(retrievedComment.PostId, retrievedPost.ID);
            Assert.Equal("Comment text", retrievedComment.MessageText);
            Assert.Equal("Post title", retrievedPost.Title);

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void AddUserInTeam_ReturnCorrectRelation()
        {
            

            var userEntity = new UserEntity
            {
                Name = "Michael"
            };

            using (var dbContextLoc = _fixture.CreateMessengerDbContext())
            {
                dbContextLoc.Users.Add(userEntity);
                dbContextLoc.SaveChanges();
            }

            var teamEntity = new TeamEntity
            {
                Name = "Red gorillas"
            };

            using (var dbContextLoc = _fixture.CreateMessengerDbContext())
            {
                dbContextLoc.Teams.Add(teamEntity);
                dbContextLoc.SaveChanges();
            }

            var userInTeamEntity = new UserInTeamEntity
            {
                UserId = userEntity.ID,
                TeamId = teamEntity.ID
            };

            using (var dbContextLoc = _fixture.CreateMessengerDbContext())
            {
                dbContextLoc.UserInTeam.Add(userInTeamEntity);
                dbContextLoc.SaveChanges();
            }

            var retrievedUserId = _fixture.MessengerDbContextSUT
                .UserInTeam
                .FirstOrDefault().UserId;

            var retrievedUser = _fixture.MessengerDbContextSUT
                .Users
                .FirstOrDefault(s => s.ID == retrievedUserId);

            var retrievedTeamId = _fixture.MessengerDbContextSUT
                .UserInTeam
                .FirstOrDefault().TeamId;

            var retrievedTeam = _fixture.MessengerDbContextSUT
                .Teams
                .FirstOrDefault(s => s.ID == retrievedTeamId);

            Assert.Equal(userEntity.ID, retrievedUserId);
            Assert.Equal(teamEntity.ID, retrievedTeamId);
            Assert.Equal("Michael", retrievedUser.Name);
            Assert.Equal("Red gorillas", retrievedTeam.Name);

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }
    }
}