using AutoMapper;
using Foundation.Core.Entities;
using Shared.DataTransferObjects;

namespace FoundationAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Be cautious when working with Dtos that are records, dont need to use some special Ctor-projection metod
            CreateMap<Character, CharacterDto>();
            CreateMap<Planet, PlanetDto>();

        }
    }
}
