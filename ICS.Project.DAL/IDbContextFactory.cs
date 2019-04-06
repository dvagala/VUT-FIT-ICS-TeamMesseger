using System;
using System.Collections.Generic;
using System.Text;

namespace ICS.Project.DAL
{
    public interface IDbContextFactory
    {
        MessengerDbContext CreateDbContext();
    }
}
