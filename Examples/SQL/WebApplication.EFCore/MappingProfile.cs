using AutoMapper;
using Database.EFCore.Entities;

namespace WebApplication.EFCore
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<CarModelEntity, CarModelDto>()
                .ForMember(
                    dst => dst.Car, 
                    opt => opt.MapFrom(src => src.Car.Name))
                .ForMember(
                    dst => dst.TypeEngine, 
                    opt => opt.MapFrom(src => src.TypeEngine))
                .ForMember(
                    dst => dst.Name,
                    opt => opt.MapFrom(src => src.Name));
        }
    }
}