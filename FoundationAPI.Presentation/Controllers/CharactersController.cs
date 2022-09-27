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
            var characters = service.CharacterService.GetAllCharacters(trackChanges: false);
            return Ok(characters);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetCharacter(Guid id)
        {
            var character = service.CharacterService.GetCharacter(id, trackChanges: false);
            return Ok(character);
        }

    }
}
