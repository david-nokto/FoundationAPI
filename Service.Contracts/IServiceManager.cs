namespace Service.Contracts
{
    public interface IServiceManager
    {
        IPlanetService PlanetService { get; }
        ICharacterService CharacterService { get; }
    }
}
