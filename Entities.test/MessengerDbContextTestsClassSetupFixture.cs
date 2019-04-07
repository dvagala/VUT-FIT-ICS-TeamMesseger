using System;
using ICS.Project.DAL;
using Microsoft.EntityFrameworkCore;

namespace Project.DAL.Tests
{
    public class MessengerDbContextTestsClassSetupFixture : IDisposable
    {
        public MessengerDbContextTestsClassSetupFixture()
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
            contextOptionsBuilder.UseInMemoryDatabase("Messenger");
            return contextOptionsBuilder.Options;
        }
    }
}