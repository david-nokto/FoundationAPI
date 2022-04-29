using AutoMapper;
using Foundation.Core.Logger;
using Foundation.Core.Repository;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    public sealed class CharacterService : ICharacterService
    {
        private readonly IUoW uoW;
        private readonly ILoggerManager logger;
        private readonly IMapper mapper;

        public CharacterService(IUoW uoW, ILoggerManager logger, IMapper mapper)
        {
            this.uoW = uoW;
            this.logger = logger;
            this.mapper = mapper;
        }

        public IEnumerable<CharacterDto> GetAllCharacters(bool trackChanges)
        {
            try
            {
                var characters = uoW.Character.GetAllCharacters(trackChanges);
                var charactersDto = mapper.Map<IEnumerable<CharacterDto>>(characters);
                return charactersDto;
            }
            catch (Exception ex)
            {
                logger.LogError($"Something went wrong in the {nameof(GetAllCharacters)} service method {ex}");
                throw;
            }
        }
    }
}