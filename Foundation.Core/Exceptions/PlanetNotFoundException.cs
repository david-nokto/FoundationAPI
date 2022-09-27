namespace Foundation.Core.Exceptions
{
    public class PlanetNotFoundException : NotFoundException
    {
        public PlanetNotFoundException(Guid planetId) : base($"Planet with id: {planetId} doesn't exist in the database")
        {

        }
    }
}
