using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface ICharacterService
    {
        IEnumerable<CharacterDto> GetAllCharacters(bool trackChanges);
    }
}