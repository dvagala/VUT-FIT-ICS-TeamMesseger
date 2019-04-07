using ICS.Project.DAL;
using ICS.Project.DAL.Entities;
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
                Assert.Equal(PEntity, retievedPost, PostEntity.TitleCommentsIdComparer);
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
            }
                
        }
        //[Fact]
        //public void CommentEntityAddTests()
        //{
            //UserEntity User = new UserEntity();
            //CommentEntity Comment = new CommentEntity();
            //Comment.Autor = User;
            //Comment.MessageText = "Ahoj!";
            //Comment.PublishDate = new TimeSpan(15, 49, 30);
  
        //}
        /*
        [Fact]

        public void UserEntityAddTest()
        {
            TeamEntity Team = new TeamEntity();
            UserEntity User = new UserEntity();
            User.Name = "Jojo";
            User.Surname = "G";
            User.LastActivity = new TimeSpan(15, 49, 30);
            User.Email = "xjojog@vutbr.cz";
            User.Password = "123jojo";
            User.Teams.Add(Team);

            using (var db = new MessengerDbContext()) ;
            db.add(User);
            db.saveChanges();
        }


        public void TeamEntityAddTest()
        {
            UserEntity User = new UserEntity();
            var PEntity = new PostEntity();
            var TEntity = new TeamEntity();
            TEntity.Name = "Bang!";
            TEntity.Description = "You're gonna carry that weight"; 
            TEntity.Users.Add(User);
            TEntity.Posts.Add(PEntity);


            using (var db = new MessengerDbContext()) ;
            db.add(TEntity);
            db.saveChanges();
        }


        public void TeamEntityDeleteTest()
        {



        }
        */
        //[Fact]
        //{
        //    ID = id,
        //    Email = "Spike@gmail.com"
        //};
        //using (var db = new DataDBContext())
        //{
        //    db.Emails.Add(TestEmailAdressEntity);
        //    db.SaveChanges();
        //}
        ////TODO Treba opravit, Addnuty email neostava v databaze
        //using (var db = new DataDBContext())
        //{
        //    var Email = db.Emails.FirstOrDefault(x => x.ID == id);
        //    Assert.Equal(TestEmailAdressEntity, Email);
        //}
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
