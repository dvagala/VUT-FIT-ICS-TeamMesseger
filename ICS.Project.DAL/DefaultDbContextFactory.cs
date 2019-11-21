using Microsoft.EntityFrameworkCore;

namespace ICS.Project.DAL
{
    public class DefaultDbContextFactory : IDbContextFactory
    {
        public MessengerDbContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MessengerDbContext>();
            optionsBuilder.UseSqlServer(
                @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = TasksDB;MultipleActiveResultSets = True;Integrated Security = True");

            return new MessengerDbContext(optionsBuilder.Options);
        }
    }
}