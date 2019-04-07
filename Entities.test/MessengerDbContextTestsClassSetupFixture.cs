using ICS.Project.DAL;
using Microsoft.EntityFrameworkCore;
using System;

namespace Project.DAL.Tests
{
    public class MessengerDbContextTestsClassSetupFixture : IDisposable
    {
        public MessengerDbContext MessengerDbContextSUT { get; set; }

        public MessengerDbContextTestsClassSetupFixture()
        {
            this.MessengerDbContextSUT = CreateMessengerDbContext();
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

        public void Dispose()
        {
            MessengerDbContextSUT?.Dispose();
        }
    }
}