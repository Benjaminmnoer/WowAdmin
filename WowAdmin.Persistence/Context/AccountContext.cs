using Microsoft.EntityFrameworkCore;

namespace WowAdmin.Persistence.Context
{
    public class AccountContext : DbContext
    {
        public AccountContext(DbContextOptions<AccountContext> contextOptions) : base(contextOptions)
        {
        }
    }
}