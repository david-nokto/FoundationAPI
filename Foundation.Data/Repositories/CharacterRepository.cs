using Foundation.Core.Entities;
using Foundation.Core.Repository;
using Foundation.Data.Data;

namespace Foundation.Data.Repositories
{
    public class CharacterRepository : RepositoryBase<Character>, ICharacterRepository
    {
        public CharacterRepository(RepositoryContext db) : base(db)
        {
        }

        public IEnumerable<Character> GetAllCharacters(bool trackChanges) =>
            FindAll(trackChanges)
                .OrderBy(c => c.Name)
                .ToList();

        public Character GetCharacter(Guid characterId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(characterId), trackChanges)
                .SingleOrDefault();


    }
}
