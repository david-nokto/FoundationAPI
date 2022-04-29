using AutoMapper;
using Foundation.Core.Logger;
using Foundation.Core.Repository;
using Service.Contracts;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICharacterService> characterService;
        private readonly Lazy<IPlanetService> planetService;
        public ServiceManager(IUoW uoW, ILoggerManager logger, IMapper mapper)
        {
            characterService = new Lazy<ICharacterService>(() => new CharacterService(uoW, logger, mapper));
            planetService = new Lazy<IPlanetService>(() => new PlanetService(uoW, logger, mapper));
        }


        public ICharacterService CharacterService => characterService.Value;
        public IPlanetService PlanetService => planetService.Value;

    }
}
