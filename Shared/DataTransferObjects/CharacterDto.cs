﻿namespace Shared.DataTransferObjects
{


    public record CharacterDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
    }
}
