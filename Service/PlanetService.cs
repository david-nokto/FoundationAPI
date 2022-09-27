using AutoMapper;
using Foundation.Core.Exceptions;
using Foundation.Core.Logger;
using Foundation.Core.Repository;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    public sealed class PlanetService : IPlanetService
    {
        private readonly IUoW uoW;
        private readonly ILoggerManager logger;
        private readonly IMapper mapper;

        public PlanetService(IUoW uoW, ILoggerManager logger, IMapper mapper)
        {
            this.uoW = uoW;
            this.logger = logger;
            this.mapper = mapper;
        }

        public IEnumerable<PlanetDto> GetPlanets(bool trackChanges)
        {
            var planets = uoW.Planet.GetPlanets(trackChanges);
            var planetsDto = mapper.Map<IEnumerable<PlanetDto>>(planets);

            return planetsDto;
        }

        public PlanetDto GetPlanet(Guid id, bool trackChanges)
        {
            var planet = uoW.Planet.GetPlanet(id, trackChanges);
            if (planet is null)
                throw new PlanetNotFoundException(id);

            var planetDto = mapper.Map<PlanetDto>(planet);
            return planetDto;


        }
    }
}
