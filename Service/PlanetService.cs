using AutoMapper;
using Foundation.Core.Logger;
using Foundation.Core.Repository;
using Service.Contracts;

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
    }
}
