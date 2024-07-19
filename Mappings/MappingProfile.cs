using AutoMapper;
using CustomerAPI.Models;

namespace CustomerAPI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<Customer, CustomerDto>().ReverseMap();
        }
    }
}
