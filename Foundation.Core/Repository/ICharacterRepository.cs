using Foundation.Core.Entities;

namespace Foundation.Core.Repository
{
    public interface ICharacterRepository
    {
        IEnumerable<Character> GetAllCharacters(bool trackChanges);
    }
}
