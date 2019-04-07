using ICS.Project.DAL;
using ICS.Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Project.DAL.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Entities.DAL.test
{
    public class EntitiesTests : IClassFixture<MessengerDbContextTestsClassSetupFixture>
    {
        public EntitiesTests(MessengerDbContextTestsClassSetupFixture testContext)
        {
            _testContext = testContext;
        }

        private readonly MessengerDbContextTestsClassSetupFixture _testContext;

        [Fact]
        public void PostEntityAddTest()
        {
            
            CommentEntity Comment = new CommentEntity();
            PostEntity PEntity = new PostEntity();
            PEntity.ID = new Guid();
            PEntity.Autor = null;
            PEntity.MessageText = "See you space cowboy!";
            PEntity.PublishDate = new DateTime(2018, 10, 10);
            PEntity.Title = "Accelerated spread of Weebs";
            


            //Act
            _testContext.MessengerDbContextSUT.Posts.Add(PEntity);
            _testContext.MessengerDbContextSUT.SaveChanges();

            //Assert
            using (var dbx = _testContext.CreateMessengerDbContext())
            {
                var retievedPost = dbx.Posts.First(entity => entity.ID == PEntity.ID);
                Assert.Equal(PEntity, retievedPost, PostEntityComparer.PostComparer);
            }
        }

        [Fact]
        public void PostEntityDeleteTest()
        {
            using (var dbx = _testContext.CreateMessengerDbContext())
            {
                PostEntity PEntity = new PostEntity() { ID = new Guid()};
                dbx.Attach(PEntity);
                dbx.Remove(PEntity);
                dbx.SaveChanges();
                Assert.Null(dbx.Posts.Find(PEntity.ID));


            }
                
        }
        [Fact]
        public void PostEntityUpdateTest()
        {
            using (var dbx = _testContext.CreateMessengerDbContext())
            {
                PostEntity PEntity = new PostEntity() { ID = new Guid() };
                PEntity.MessageText = "Pre-Update text";
                dbx.Attach(PEntity);
                dbx.Add(PEntity);
                dbx.SaveChanges();
                dbx.Update(dbx.Posts.Find(PEntity.ID));
                dbx.Posts.Find(PEntity.ID).MessageText = "Post-Update text";
                dbx.SaveChanges();
                string postUpdate = "Post-Update text";
                Console.WriteLine(dbx.Posts.Find(PEntity.ID).MessageText);
                Assert.Equal(postUpdate,dbx.Posts.Find(PEntity.ID).MessageText);
            }
        }

        [Fact]
        public void CommentEntityAddTests()
        {
            //UserEntity User = new UserEntity(); TODO Zistit ako pridat entitu v entite do databazy
            CommentEntity Comment = new CommentEntity();
            Comment.Autor = null;
            Comment.MessageText = "Ahoj!";
            Comment.PublishDate = new DateTime(2018, 10, 10);

            //Act
            _testContext.MessengerDbContextSUT.Comments.Add(Comment);
            _testContext.MessengerDbContextSUT.SaveChanges();

            //Assert
            using (var dbx = _testContext.CreateMessengerDbContext())
            {
                var retrievedComment = dbx.Comments.First(entity => entity.ID == Comment.ID);
                Assert.Equal(Comment.Autor,retrievedComment.Autor);
                Assert.Equal(Comment.MessageText, retrievedComment.MessageText);
                Assert.Equal(Comment.PublishDate, retrievedComment.PublishDate);
                Assert.Equal(Comment.ID, retrievedComment.ID);
            }

        }

        [Fact]
        public void CommentEntityDeleteTest()
        {
            using (var dbx = _testContext.CreateMessengerDbContext())
            {
                CommentEntity Comment = new CommentEntity() { ID = new Guid() };
                dbx.Attach(Comment);
                dbx.Remove(Comment);
                dbx.SaveChanges();
                Assert.Null(dbx.Comments.Find(Comment.ID));
            }

        }
        
        [Fact]
        public void UserEntityAddTest()
        {
            TeamEntity Team = new TeamEntity();
            UserEntity User = new UserEntity();
            User.Name = "Jojo";
            User.Surname = "G";
            User.LastActivity = new DateTime(2017, 5, 5);
            User.Email = "xjojog@vutbr.cz";
            User.Password = "123jojo";
            //User.Teams.Add(Team); TODO zistit ako pridavat entitu v entite do databazy
            

            //Act
            _testContext.MessengerDbContextSUT.Users.Add(User);
            _testContext.MessengerDbContextSUT.SaveChanges();

            //Assert
            using (var dbx = _testContext.CreateMessengerDbContext())
            {
                var retievedUser = dbx.Users.First(entity => entity.ID == User.ID);
                Assert.Equal(User, retievedUser, UserEntity.UserComparer);
            }
        }
        [Fact]
        public void UserEntityDeleteTest()
        {
            using (var dbx = _testContext.CreateMessengerDbContext())
            {
                UserEntity User = new UserEntity() { ID = new Guid() };
                dbx.Attach(User);
                dbx.Remove(User);
                dbx.SaveChanges();
                Assert.Null(dbx.Users.Find(User.ID));
            }

        }

        [Fact]
        public void UserEntityUpdateTest()
        {
            using (var dbx = _testContext.CreateMessengerDbContext())
            {
                UserEntity User = new UserEntity() { ID = new Guid() };
                User.Name = "Jojo";
                dbx.Attach(User);
                dbx.Add(User);
                dbx.SaveChanges();
                dbx.Update(dbx.Users.Find(User.ID));
                dbx.Users.Find(User.ID).Name = "Joji";
                dbx.SaveChanges();
                string postUpdate = "Joji";
                Console.WriteLine(dbx.Users.Find(User.ID).Name);
                Assert.Equal(postUpdate, dbx.Users.Find(User.ID).Name);
            }
        }

        [Fact]
        public void TeamEntityAddTest()
        {
            UserEntity User = new UserEntity();
            var PEntity = new PostEntity();
            var TEntity = new TeamEntity();
            TEntity.Name = "Bang!";
            TEntity.Description = "You're gonna carry that weight";

            //Add
            _testContext.MessengerDbContextSUT.Teams.Add(TEntity);
            _testContext.MessengerDbContextSUT.SaveChanges();

            //Assert
            using (var dbx = _testContext.CreateMessengerDbContext())
            {
                var retievedTeam = dbx.Teams.First(entity => entity.ID == TEntity.ID);
                Assert.Equal(TEntity, retievedTeam, TeamEntityComparer.TeamComparer);
            }

        }

        [Fact]
        public void TeamEntityDeleteTest()
        {
            using (var dbx = _testContext.CreateMessengerDbContext())
            {
                TeamEntity Team  = new TeamEntity() { ID = new Guid() };
                dbx.Attach(Team);
                dbx.Remove(Team);
                dbx.SaveChanges();

                Assert.Null(dbx.Teams.Find(Team.ID));
            }
        

        }

        [Fact]
        public void TeamEntityUpdateTest()
        {
            using (var dbx = _testContext.CreateMessengerDbContext())
            {
                TeamEntity Team = new TeamEntity() { ID = new Guid() };
                Team.Description = "Number 1";
                dbx.Attach(Team);
                dbx.Add(Team);
                dbx.SaveChanges();
                dbx.Update(dbx.Teams.Find(Team.ID));
                dbx.Teams.Find(Team.ID).Description = "Number 2";
                dbx.SaveChanges();
                string postUpdate = "Number 2";
                Console.WriteLine(dbx.Teams.Find(Team.ID).Description);
                Assert.Equal(postUpdate, dbx.Teams.Find(Team.ID).Description);
            }
        }




    }

    //[Fact]
    //public void UserEntityTest()
    //{

    //    var id = new Guid();
    //    var TestUserEntity = new UserEntity
    //    {
    //        ID = id,
    //        UserName = "Spike",
    //        LastActivity = new TimeSpan(15, 10, 5),
    //        Email = new EmailAdressEntity
    //        {
    //            ID = new Guid(),
    //            Email = "Spiegel@gmail.com"
    //        }
    //};

    //    using (var db = new DataDBContext()) 
    //    {
    //        db.Users.Add(TestUserEntity);
    //        db.SaveChanges();
    //    }

    //    using (var db = new DataDBContext())
    //    {
    //        var User = db.Users.FirstOrDefault();
    //        Assert.Equal(TestUserEntity,User);


    //    }

    //}


    //}
    //[Fact]
    //public void CommentEntityTests()
    //{
    //    UserEntity User = new UserEntity();
    //    CommentEntity Comment = new CommentEntity();
    //    Comment.Autor = User;
    //    Comment.MessageText = "Ahoj!";
    //    Comment.PublishDate = new TimeSpan(15, 49, 30);
    //}
    //[Fact]
    //public void PostEntityTest()
    //{
    //    CommentEntity Comment = new CommentEntity();
    //    PostEntity PEntity = new PostEntity();
    //    PEntity.ID = new Guid();
    //    PEntity.MessageText = "See you space cowboy!";
    //    PEntity.PublishDate = new TimeSpan(10, 10, 10);
    //    PEntity.Title = "Accelerated spread of Weebs";
    //    PEntity.Comments.Add(Comment);
    //}
    //[Fact]
    //public void TeamEntityTest()
    //{
    //    UserEntity User = new UserEntity();
    //    var PEntity = new PostEntity();
    //    var TEntity = new TeamEntity();
    //    TEntity.Name = "Bang!";
    //    TEntity.Description = "You're gonna carry that weight";
    //    TEntity.Users.Add(User);
    //    TEntity.Posts.Add(PEntity);
    //}

    //[Fact]


    //MessemgerDbContext

}
