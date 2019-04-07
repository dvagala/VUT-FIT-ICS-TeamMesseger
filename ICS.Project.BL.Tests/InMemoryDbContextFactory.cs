using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ICS.Project.DAL;

namespace ICS.Project.BL.Tests
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
}
