using AutoMapper;
using Foundation.Core.Exceptions;
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

            var characters = uoW.Character.GetAllCharacters(trackChanges);
            var charactersDto = mapper.Map<IEnumerable<CharacterDto>>(characters);
            return charactersDto;


        }

        public CharacterDto GetCharacter(Guid id, bool trackChanges)
        {
            var character = uoW.Character.GetCharacter(id, trackChanges);
            if (character == null)
                throw new CharacterNotFoundException(id);

            var characterDto = mapper.Map<CharacterDto>(character);
            return characterDto;
        }
    }
}