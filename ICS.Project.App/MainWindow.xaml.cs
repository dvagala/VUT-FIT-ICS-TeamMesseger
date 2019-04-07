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
using ICS.Project.BL.Mapper;
using ICS.Project.BL.Models;
using ICS.Project.BL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ICS.Project.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        // Do not go here, this is all just for quick nasty testing


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

            dbContextFactory = new DefaultDbContextFactory();

            IMapper mapper = new Mapper();

            PostsRepository postsRepository = new PostsRepository(dbContextFactory, mapper);

            PostModel todoDetailModel = new PostModel
            {
                Title = "Hoo5"
            };

            using (var dbContext = dbContextFactory.CreateDbContext())
            {
                ICollection<PostEntity> retrievedAllPostEntities = null;
                try
                {
                    PostEntity finded = dbContext.Posts.FirstOrDefault(e => e.Title == "Hoo5");

                    PostModel a = postsRepository.GetById(finded.ID);

                    myLabel.Content = a.Title;

                    //if (finded != null)
                    //    postsRepository.Remove(finded.ID);

                    //retrievedAllPostEntities = dbContext.Posts.ToList();

                    //String str = "Post Entities:\n\n";

                    //foreach (var item in retrievedAllPostEntities)
                    //{
                    //    str += item.Title + "\n";
                    //}

                    //myLabel.Content = str;

                }
                finally
                {
                    //////Teardown
                    //if (retrievedPostEntity != null)
                    //{
                    //    dbContext.Posts.Remove(retrievedPostEntity);
                    //}
                }
            }


        }
    }
}
