namespace Foundation.Core.Exceptions
{
    public sealed class CharacterNotFoundException : NotFoundException
    {
        public CharacterNotFoundException(Guid characterId) : base($"The character with id: {characterId} doesn't exist in the database.")
        {

        }
    }
}
