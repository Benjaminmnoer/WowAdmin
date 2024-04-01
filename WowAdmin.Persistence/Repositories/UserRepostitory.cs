using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WowAdmin.Persistence.Context;

namespace WowAdmin.Persistence.Repositories
{
    public class UserRepostitory
    {
        private readonly UserContext _userContext;

        public UserRepostitory(UserContext userContext)
        {
            _userContext = userContext;
        }

        public Task<bool> CreateUser()
        {
            return Task.FromResult<bool>(true);
        }
    }
}
