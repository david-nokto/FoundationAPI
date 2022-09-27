using Foundation.Core.Entities;

namespace Foundation.Core.Repository
{
    public interface IPlanetRepository
    {
        IEnumerable<Planet> GetPlanets(bool trackChanges);
        Planet GetPlanet(Guid planetId, bool trackChanges);

    }
}
