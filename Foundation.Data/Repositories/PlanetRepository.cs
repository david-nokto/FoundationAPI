using Foundation.Core.Entities;
using Foundation.Core.Repository;
using Foundation.Data.Data;

namespace Foundation.Data.Repositories
{
    public class PlanetRepository : RepositoryBase<Planet>, IPlanetRepository
    {
        public PlanetRepository(RepositoryContext db) : base(db)
        {

        }

        public IEnumerable<Planet> GetPlanets(bool trackChanges) =>
            FindAll(trackChanges)
                .OrderBy(c => c.Name)
                .ToList();

        public Planet GetPlanet(Guid id, bool trackChanges) =>
            FindByCondition(p => p.Id == id, trackChanges)
                .SingleOrDefault();



    }
}
