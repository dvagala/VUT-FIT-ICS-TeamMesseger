using System;
using System.Linq;
using ICS.Project.DAL.Entities;
using Xunit;

[assembly: CollectionBehavior(DisableTestParallelization = true)]

namespace ICS.Project.DAL.Tests
{
    public class EntitiesTests : IClassFixture<EntitiesTestsFixture>
    {
        public EntitiesTests(EntitiesTestsFixture fixture)
        {
            _fixture = fixture;
        }

        private readonly EntitiesTestsFixture _fixture;

        [Fact]
        public void CommentEntityAddTests()
        {
            var Comment = new CommentEntity();
            Comment.MessageText = "Ahoj!";
            Comment.PublishDate = new DateTime(2018, 10, 10);

            //Act
            _fixture.MessengerDbContextSUT.Comments.Add(Comment);
            _fixture.MessengerDbContextSUT.SaveChanges();

            //Assert
            using (var dbx = _fixture.CreateMessengerDbContext())
            {
                var retrievedComment = dbx.Comments.First(entity => entity.ID == Comment.ID);
                Assert.Equal(Comment.MessageText, retrievedComment.MessageText);
                Assert.Equal(Comment.PublishDate, retrievedComment.PublishDate);
                Assert.Equal(Comment.ID, retrievedComment.ID);
            }

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void CommentEntityDeleteTest()
        {
            using (var dbx = _fixture.CreateMessengerDbContext())
            {
                var Comment = new CommentEntity {ID = new Guid()};
                dbx.Attach(Comment);
                dbx.Remove(Comment);
                dbx.SaveChanges();
                Assert.Null(dbx.Comments.Find(Comment.ID));
            }

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void PostEntityAddTest()
        {
            var PEntity = new PostEntity();
            PEntity.ID = new Guid();
            PEntity.MessageText = "See you space cowboy!";
            PEntity.PublishDate = new DateTime(2018, 10, 10);
            PEntity.Title = "Accelerated spread of Weebs";
            PEntity.AuthorId = new Guid();


            //Act
            _fixture.MessengerDbContextSUT.Posts.Add(PEntity);
            _fixture.MessengerDbContextSUT.SaveChanges();

            //Assert
            using (var dbx = _fixture.CreateMessengerDbContext())
            {
                var retievedPost = dbx.Posts.First(entity => entity.ID == PEntity.ID);
                Assert.Equal(PEntity, retievedPost, PostEntityComparer.PostComparer);
            }

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void PostEntityDeleteTest()
        {
            using (var dbx = _fixture.CreateMessengerDbContext())
            {
                var PEntity = new PostEntity {ID = new Guid()};
                dbx.Attach(PEntity);
                dbx.Remove(PEntity);
                dbx.SaveChanges();
                Assert.Null(dbx.Posts.Find(PEntity.ID));
            }

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void PostEntityUpdateTest()
        {
            using (var dbx = _fixture.CreateMessengerDbContext())
            {
                var PEntity = new PostEntity {ID = new Guid()};
                PEntity.MessageText = "Pre-Update text";
                dbx.Attach(PEntity);
                dbx.Add(PEntity);
                dbx.SaveChanges();
                dbx.Update(dbx.Posts.Find(PEntity.ID));
                dbx.Posts.Find(PEntity.ID).MessageText = "Post-Update text";
                dbx.SaveChanges();
                var postUpdate = "Post-Update text";
                Console.WriteLine(dbx.Posts.Find(PEntity.ID).MessageText);
                Assert.Equal(postUpdate, dbx.Posts.Find(PEntity.ID).MessageText);
            }

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void TeamEntityAddTest()
        {
            var TEntity = new TeamEntity();
            TEntity.Name = "Bang!";
            TEntity.Description = "You're gonna carry that weight";

            //Add
            _fixture.MessengerDbContextSUT.Teams.Add(TEntity);
            _fixture.MessengerDbContextSUT.SaveChanges();

            //Assert
            using (var dbx = _fixture.CreateMessengerDbContext())
            {
                var retievedTeam = dbx.Teams.First(entity => entity.ID == TEntity.ID);
                Assert.Equal(TEntity, retievedTeam, TeamEntityComparer.TeamComparer);
            }

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void TeamEntityDeleteTest()
        {
            using (var dbx = _fixture.CreateMessengerDbContext())
            {
                var Team = new TeamEntity {ID = new Guid()};
                dbx.Attach(Team);
                dbx.Remove(Team);
                dbx.SaveChanges();

                Assert.Null(dbx.Teams.Find(Team.ID));
            }

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void TeamEntityUpdateTest()
        {
            using (var dbx = _fixture.CreateMessengerDbContext())
            {
                var Team = new TeamEntity {ID = new Guid()};
                Team.Description = "Number 1";
                dbx.Attach(Team);
                dbx.Add(Team);
                dbx.SaveChanges();
                dbx.Update(dbx.Teams.Find(Team.ID));
                dbx.Teams.Find(Team.ID).Description = "Number 2";
                dbx.SaveChanges();
                var postUpdate = "Number 2";
                Console.WriteLine(dbx.Teams.Find(Team.ID).Description);
                Assert.Equal(postUpdate, dbx.Teams.Find(Team.ID).Description);
            }

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void UserEntityAddTest()
        {
            var User = new UserEntity();
            User.Name = "Jojo";
            User.Surname = "G";
            User.LastActivity = new DateTime(2017, 5, 5);
            User.Email = "xjojog@vutbr.cz";
//            User.Password = "123jojo";


            //Act
            _fixture.MessengerDbContextSUT.Users.Add(User);
            _fixture.MessengerDbContextSUT.SaveChanges();

            //Assert
            using (var dbx = _fixture.CreateMessengerDbContext())
            {
                var retievedUser = dbx.Users.First(entity => entity.ID == User.ID);
                Assert.Equal(User, retievedUser, UserEntityComparer.UserComparer);
            }

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void UserEntityDeleteTest()
        {
            using (var dbx = _fixture.CreateMessengerDbContext())
            {
                var User = new UserEntity {ID = new Guid()};
                dbx.Attach(User);
                dbx.Remove(User);
                dbx.SaveChanges();
                Assert.Null(dbx.Users.Find(User.ID));
            }

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }

        [Fact]
        public void UserEntityUpdateTest()
        {
            using (var dbx = _fixture.CreateMessengerDbContext())
            {
                var User = new UserEntity {ID = new Guid()};
                User.Name = "Jojo";
                dbx.Attach(User);
                dbx.Add(User);
                dbx.SaveChanges();
                dbx.Update(dbx.Users.Find(User.ID));
                dbx.Users.Find(User.ID).Name = "Joji";
                dbx.SaveChanges();
                var postUpdate = "Joji";
                Console.WriteLine(dbx.Users.Find(User.ID).Name);
                Assert.Equal(postUpdate, dbx.Users.Find(User.ID).Name);
            }

            //Teardown
            _fixture.MessengerDbContextSUT.Database.EnsureDeleted();
        }
    }
}