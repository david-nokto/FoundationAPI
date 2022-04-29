namespace Foundation.Core.Repository
{
    public interface IUoW
    {
        ICharacterRepository Character { get; }
        IPlanetRepository Planet { get; }
        void Save();
    }
}
