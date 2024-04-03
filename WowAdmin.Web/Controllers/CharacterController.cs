using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using WowAdmin.Persistence.Repositories;
using WowAdmin.Web.Requests;
using WowAdmin.Web.Responses;

namespace WowAdmin.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ILogger<CharacterController> _logger;
        private readonly CharacterRepository _characterRepository;

        public CharacterController(ILogger<CharacterController> logger, CharacterRepository characterRepository)
        {
            _logger = logger;
            _characterRepository = characterRepository;
        }

        [HttpPost]
        [Route("AddCharactter")]
        [SwaggerResponse((int)HttpStatusCode.OK, "Success", typeof(AddCharacterResponse))]
        public async Task<IActionResult> AddAccount(AddCharacterRequest request)
        {
            var (success, error) = await _characterRepository.AddCharacter(request.Name, request.Level, request.Race, request.Class);
            if (!success)
            {
                return StatusCode(500, new AddCharacterResponse { Name = request.Name, Success = false, Error = error });
            }

            return Ok(new AddCharacterResponse { Name = request.Name, Success = true });
        }
    }
}
