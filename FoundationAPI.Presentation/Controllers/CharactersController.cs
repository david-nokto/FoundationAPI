using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace Foundation.Presentation.Controllers
{
    [Route("api/characters")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly IServiceManager service;

        public CharactersController(IServiceManager service) => this.service = service;

        [HttpGet]
        public IActionResult GetCharacters()
        {
            try
            {
                var characters = service.CharacterService.GetAllCharacters(trackChanges: false);
                return Ok(characters);
            }
            catch
            {

                return StatusCode(500, "Internal server error");
            }
        }

    }
}
