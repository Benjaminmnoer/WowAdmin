using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowAdmin.Persistence.Context;

namespace WowAdmin.Persistence.Repositories
{
    public class AccountRepository
    {
        private readonly UserContext _userContext;
        private const int G = 7;
        private const string hex = "894B645E89E1535BBDAD5B8B290650530801B18EBFBF5E8FAB3C82872A3E9BB7";

        public AccountRepository(UserContext userContext)
        {
            _userContext = userContext;
        }

        public Task<bool> CreateUser(string accountName, string password, string? email)
        {
            return Task.FromResult<bool>(true);
        }
    }
}
