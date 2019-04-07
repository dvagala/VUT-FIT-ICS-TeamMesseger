using ICS.Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ICS.Project.DAL
{
    public class MessengerDbContext : DbContext
    {

        public MessengerDbContext()
        {
        }

        public MessengerDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<CommentEntity> Comments { get; set; }
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<TeamEntity> Teams { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }
}
