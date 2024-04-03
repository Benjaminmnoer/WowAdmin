using Microsoft.EntityFrameworkCore;

namespace WowAdmin.Persistence.Context
{
    public class WorldContext : DbContext
    {
        public WorldContext(DbContextOptions<WorldContext> contextOptions) : base(contextOptions)
        {
        }
    }
}
