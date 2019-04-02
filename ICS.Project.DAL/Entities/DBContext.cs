using ICS.Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;


namespace ICS.Project.DAL
{
    public class DataDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Project;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }


        public DbSet<EmailAdressEntity> Emails { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<TeamEntity> Teams { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }
}
