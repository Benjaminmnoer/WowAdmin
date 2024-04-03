using Microsoft.EntityFrameworkCore;

namespace WowAdmin.Persistence.Context
{
    public class CharacterContext : DbContext
    {
        public CharacterContext(DbContextOptions<CharacterContext> contextOptions) : base(contextOptions)
        {
        }
    }
}
