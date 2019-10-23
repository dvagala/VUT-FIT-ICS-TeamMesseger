using ICS.Project.BL.Repositories;
using ICS.Project.DAL;

namespace ICS.Project.BL.Tests
{
    public class RepositoryLayerTestsFixture
    {
        public RepositoryLayerTestsFixture()
        {
            PostsRepository = new PostsRepository(new InMemoryDbContextFactory());
            UsersRepository = new UsersRepository(new InMemoryDbContextFactory());
            TeamsRepository = new TeamsRepository(new InMemoryDbContextFactory());
            CommentsRepository = new CommentsRepository(new InMemoryDbContextFactory());

            IDbContextFactory dbContextFactory = new InMemoryDbContextFactory();
            MessengerDbContextSUT = dbContextFactory.CreateDbContext();
        }

        public MessengerDbContext MessengerDbContextSUT { get; set; }

        public IPostsRepository PostsRepository { get; }
        public IUsersRepository UsersRepository { get; }
        public ITeamsRepository TeamsRepository { get; }
        public ICommentsRepository CommentsRepository { get; }
    }
}