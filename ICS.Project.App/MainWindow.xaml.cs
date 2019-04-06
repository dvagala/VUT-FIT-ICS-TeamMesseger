using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ICS.Project.DAL.Entities;
using ICS.Project.DAL;
using Microsoft.EntityFrameworkCore;

namespace ICS.Project.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public class InMemoryDbContextFactory : IDbContextFactory
        {
            public MessengerDbContext CreateDbContext()
            {
                var optionsBuilder = new DbContextOptionsBuilder<MessengerDbContext>();
                optionsBuilder.UseInMemoryDatabase("TodoDbName");
                return new MessengerDbContext(optionsBuilder.Options);
            }
        }

        private readonly IDbContextFactory dbContextFactory;

        public MainWindow()
        {
            InitializeComponent();

            //dbContextFactory = new InMemoryDbContextFactory();
            dbContextFactory = new DefaultDbContextFactory();

            //Arrange
            //var postEntity = new PostEntity
            //{
            //    Title = "Post title"
            //};

            ////Act
            //using (var dbContext = dbContextFactory.CreateDbContext())
            //{
            //    dbContext.Posts.Add(postEntity);
            //    dbContext.SaveChanges();
            //}

            //Assert
            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                PostEntity retrievedPostEntity = null;
                try
                {
                    retrievedPostEntity = dbContext.Posts.First();
                    myLabel.Content = retrievedPostEntity.Title;
                    //Assert.NotNull(retrievedPerson);
                }
                finally
                {
                    ////Teardown
                    //if (retrievedPerson != null)
                    //{
                    //    dbContext.People.Remove(retrievedPerson);
                    //}
                }
            }


        }
    }
}
