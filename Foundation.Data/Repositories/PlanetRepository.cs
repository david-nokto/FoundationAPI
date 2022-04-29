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
    }
}
