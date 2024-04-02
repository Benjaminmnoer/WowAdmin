using System.Net;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;
using WowAdmin.Persistence.Repositories;
using WowAdmin.Web.Requests;
using WowAdmin.Web.Responses;

namespace WowAdmin.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly AccountRepository _accountRepository;

        public UserController(ILogger<UserController> logger, AccountRepository userRepostitory)
        {
            _logger = logger;
            _accountRepository = userRepostitory;
        }

        [HttpPost]
        [Route("AddAccount")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Success", typeof(AddAccountResponse))]
        public async Task<IActionResult> AddUser(AddAccountRequest request)
        {
            var result = await _accountRepository.CreateUser(request.AccountName, request.Password, request.Email);

            return Ok(new AddAccountResponse { AccountName = request.AccountName, Success = true });
        }        
    }
}
