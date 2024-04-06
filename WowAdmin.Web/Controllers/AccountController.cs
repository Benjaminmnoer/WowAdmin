using System.Net;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WowAdmin.Persistence.Repositories;
using WowAdmin.Web.Requests;
using WowAdmin.Web.Responses;

namespace WowAdmin.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;
        private readonly AccountRepository _accountRepository;

        public AccountController(ILogger<AccountController> logger, AccountRepository accountRepository)
        {
            _logger = logger;
            _accountRepository = accountRepository;
        }

        [HttpPost]
        [Route("AddAccount")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Success", typeof(AddAccountResponse))]
        public async Task<IActionResult> AddAccount(AddAccountRequest request)
        {
            var (accountId, error) = await _accountRepository.CreateUser(request.AccountName, request.Password, request.Email);
            if (accountId < 0)
            {
                return BadRequest(new AddAccountResponse { AccountId = accountId, AccountName = request.AccountName, Success = false, Error = error });
            }

            return Ok(new AddAccountResponse { AccountId = accountId, AccountName = request.AccountName, Success = true });
        }        
    }
}
