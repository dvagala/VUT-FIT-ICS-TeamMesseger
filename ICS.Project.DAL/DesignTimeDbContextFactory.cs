using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ICS.Project.DAL
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MessengerDbContext>
    {
        public MessengerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MessengerDbContext>();
            optionsBuilder.UseSqlServer(
                @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog = TasksDB;MultipleActiveResultSets = True;Integrated Security = True");

            return new MessengerDbContext(optionsBuilder.Options);
        }
    }
}