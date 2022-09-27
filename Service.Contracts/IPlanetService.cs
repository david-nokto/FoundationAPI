using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IPlanetService
    {
        IEnumerable<PlanetDto> GetPlanets(bool trackChanges);
        PlanetDto GetPlanet(Guid id, bool trackChanges);
    }
}
