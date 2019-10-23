using System;
using Microsoft.EntityFrameworkCore;

namespace ICS.Project.DAL.Tests
{
    public class EntitiesTestsFixture : IDisposable
    {
        public EntitiesTestsFixture()
        {
            MessengerDbContextSUT = CreateMessengerDbContext();
        }

        public MessengerDbContext MessengerDbContextSUT { get; set; }

        public void Dispose()
        {
            MessengerDbContextSUT?.Dispose();
        }

        public MessengerDbContext CreateMessengerDbContext()
        {
            return new MessengerDbContext(CreateDbContextOptions());
        }

        private DbContextOptions<MessengerDbContext> CreateDbContextOptions()
        {
            var contextOptionsBuilder = new DbContextOptionsBuilder<MessengerDbContext>();
            contextOptionsBuilder.UseInMemoryDatabase("MessengerDb");
            return contextOptionsBuilder.Options;
        }
    }
}