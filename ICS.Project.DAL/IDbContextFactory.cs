namespace ICS.Project.DAL
{
    public interface IDbContextFactory
    {
        MessengerDbContext CreateDbContext();
    }
}