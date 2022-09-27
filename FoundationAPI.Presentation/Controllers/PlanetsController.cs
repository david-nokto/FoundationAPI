using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace Foundation.Presentation.Controllers
{
    [Route("api/planets")]
    public class PlanetsController : ControllerBase
    {
        private readonly IServiceManager service;

        public PlanetsController(IServiceManager service) => this.service = service;

        [HttpGet]
        public IActionResult GetPlanets()
        {
            var planets = service.PlanetService.GetPlanets(trackChanges: false);
            return Ok(planets);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetPlanet(Guid id)
        {
            var planet = service.PlanetService.GetPlanet(id, trackChanges: false);
            return Ok(planet);
        }



    }
}
