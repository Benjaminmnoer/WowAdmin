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
        private readonly UserRepostitory _userRepository;

        public UserController(ILogger<UserController> logger, UserRepostitory userRepostitory)
        {
            _logger = logger;
            _userRepository = userRepostitory;
        }

        [HttpPost]
        [Route("AddUser")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Success", typeof(AddUserResponse))]
        public IActionResult AddUser(AddUserRequest request)
        {
            return Ok();
        }        
    }
}
