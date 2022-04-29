using AutoMapper;
using Foundation.Core.Entities;
using Shared.DataTransferObjects;

namespace FoundationAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Character, CharacterDto>();

        }
    }
}
