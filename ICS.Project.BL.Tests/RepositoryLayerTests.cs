using System;
using Xunit;
using ICS.Project.BL.Mapper;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ICS.Project.BL.Tests
{
    public class RepositoryLayerTests
    {

        [Fact]
        public void GetAll_WithNoData_ReturnsEmptyEnumerable()
        {
            //Arrange
            var sut = CreatePostsSUT();

            //Act
            var models = sut.GetAll();

            //Assert
            Assert.False(models.Any());
        }

        [Fact]
        public void FindById_ExistingItem_ReturnsIt()
        {
            //Arrange
            var sut = CreateUsersSUT();            

            var posts = new System.Collections.Generic.List<PostModel> { };

            var teams = new System.Collections.Generic.List<TeamModel> { new TeamModel { Name = "Heroes", Description = "Some descr", Posts = posts } };

            var user = new UserModel { Email = "user@gmail.com", LastActivity = new DateTime(2018, 9, 3, 2, 4, 2), Name = "Alfonz", Surname = "Puk", Teams = teams };

            var model = sut.Add(user);

            try
            {
                //Act
                var foundModel = sut.GetById(model.ID);

                //Assert
                Assert.NotNull(foundModel);
            }
            finally
            {
                //Teardown
                sut.Remove(model.ID);
            }
        }

        [Fact]
        public void Remove_ExistingItem_RemovesIt()
        {
            //Arrange

            var sut = CreateUsersSUT();

            var posts = new System.Collections.Generic.List<PostModel> { };

            var teams = new System.Collections.Generic.List<TeamModel> { new TeamModel { Name = "Heroes", Description = "Some descr", Posts = posts } };

            var user = new UserModel { Email = "user@gmail.com", LastActivity = new DateTime(2018, 9, 3, 2, 4, 2), Name = "Alfonz", Surname = "Puk", Teams = teams };
            
            var model = sut.Add(user);

            //Act
            sut.Remove(model.ID);

            //Assert
            Assert.Null(sut.GetById(model.ID));
        }

        [Fact]
        public void Add_WithValidData_ReturnsCreatedItem()
        {
            //Arrange
            var sut = CreatePostsSUT();

            var posts = new System.Collections.Generic.List<PostModel> { };

            var teams = new System.Collections.Generic.List<TeamModel> { new TeamModel { Name = "Heroes", Description = "Some descr", Posts = posts } };

            var user = new UserModel { Email = "user@gmail.com", LastActivity = new DateTime(2018, 9, 3, 2, 4, 2), Name = "Alfonz", Surname = "Puk", Teams = teams };

            var comments = new System.Collections.Generic.List<CommentModel> { new CommentModel { Autor = user, MessageText = "This is comment", PublishDate = new DateTime(2017, 9, 3, 2, 4, 2) } };

            var post = new PostModel { Autor = user, MessageText = "Hello mates", Comments = comments, PublishDate = new DateTime(2017, 8, 3, 2, 4, 2), Title = "This is title" };

            PostModel model = null;

            try
            {
                //Act
                model = sut.Add(post);

                //Assert
                Assert.NotNull(model);
            }
            finally
            {
                //Teardown
                if (model != null)
                {
                    sut.Remove(model.ID);
                }
            }
        }


        [Fact]
        public void FindById_ExistingItem_ReturnCorrectPostTitle()
        {
            var sut = CreatePostsSUT();

            var posts = new System.Collections.Generic.List<PostModel> { };

            var teams = new System.Collections.Generic.List<TeamModel> { new TeamModel { Name = "Heroes", Description = "Some descr", Posts = posts } };

            var user = new UserModel { Email = "user@gmail.com", LastActivity = new DateTime(2018, 9, 3, 2, 4, 2), Name = "Alfonz", Surname = "Puk", Teams = teams };

            var comments = new System.Collections.Generic.List<CommentModel> { new CommentModel { Autor = user, MessageText = "This is comment", PublishDate = new DateTime(2017, 9, 3, 2, 4, 2) } };

            var post = new PostModel { Autor = user, MessageText = "Hello mates", Comments = comments, PublishDate = new DateTime(2017, 8, 3, 2, 4, 2), Title = "This is title" };

            var model = sut.Add(post);

            try
            {
                //Act
                var foundModel = sut.GetById(model.ID);

                //Assert
                Assert.Equal("This is title", foundModel.Title);
            }
            finally
            {
                //Teardown
                sut.Remove(model.ID);
            }
        }

        [Fact]
        public void FindById_ExistingItem_ReturnCorrectUserLastActivity()
        {
            //Arrange
            var sut = CreateUsersSUT();

            var posts = new System.Collections.Generic.List<PostModel> { };

            var teams = new System.Collections.Generic.List<TeamModel> { new TeamModel { Name = "Heroes", Description = "Some descr", Posts = posts } };

            var user = new UserModel { Email = "user@gmail.com", LastActivity = new DateTime(2018, 9, 3, 2, 4, 2), Name = "Alfonz", Surname = "Puk", Teams = teams };

            var model = sut.Add(user);

            try
            {
                //Act
                var foundModel = sut.GetById(model.ID);

                //Assert
                Assert.Equal((new DateTime(2018, 9, 3, 2, 4, 2)).Date, foundModel.LastActivity.Date);
            }
            finally
            {
                //Teardown
                sut.Remove(model.ID);
            }
        }

        [Fact]
        public void FindById_ExistingItem_ReturnCorrectUserMail()
        {
            //Arrange
            var sut = CreateUsersSUT();

            var posts = new System.Collections.Generic.List<PostModel> { };

            var teams = new System.Collections.Generic.List<TeamModel> { new TeamModel { Name = "Heroes", Description = "Some descr", Posts = posts } };

            var user = new UserModel { Email = "user@gmail.com", LastActivity = new DateTime(2018, 9, 3, 2, 4, 2), Name = "Alfonz", Surname = "Puk", Teams = teams };

            var model = sut.Add(user);

            try
            {
                //Act
                var foundModel = sut.GetById(model.ID);

                //Assert
                Assert.Equal("user@gmail.com", foundModel.Email);
            }
            finally
            {
                //Teardown
                sut.Remove(model.ID);
            }
        }


        private IPostsRepository CreatePostsSUT()
        {
            return new PostsRepository(new InMemoryDbContextFactory(), new Mapper.Mapper());
        }

        private IUsersRepository CreateUsersSUT()
        {
            return new UsersRepository(new InMemoryDbContextFactory(), new Mapper.Mapper());
        }
    }
}
