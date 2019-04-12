using ICS.Project.DAL;
using Microsoft.EntityFrameworkCore;

namespace ICS.Project.BL.Tests
{
    public class InMemoryDbContextFactory : IDbContextFactory
    {
        public MessengerDbContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<MessengerDbContext>();
            optionsBuilder.UseInMemoryDatabase("MessengerDb");
            return new MessengerDbContext(optionsBuilder.Options);
        }
    }
}