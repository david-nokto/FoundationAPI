using Foundation.Core.Repository;
using Foundation.Data.Data;

namespace Foundation.Data.Repositories
{
    public sealed class UoW : IUoW
    {
        private readonly RepositoryContext db;
        private readonly Lazy<ICharacterRepository> characterRepository;
        private readonly Lazy<IPlanetRepository> planetRepository;

        public UoW(RepositoryContext db)
        {
            this.db = db;
            characterRepository = new Lazy<ICharacterRepository>(() => new CharacterRepository(db));
            planetRepository = new Lazy<IPlanetRepository>(() => new PlanetRepository(db));
        }

        public ICharacterRepository Character => characterRepository.Value;
        public IPlanetRepository Planet => planetRepository.Value;

        public void Save() => db.SaveChanges();
    }


}
