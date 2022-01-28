using AutoMapper;
using VeiculoApi.Data.Dtos;
using VeiculoApi.Models;

namespace VeiculoApi.Profiles
{
    public class DonoProfile : Profile
    {
        public DonoProfile()
        {
            CreateMap<CreateDonoDto, Dono>();
            CreateMap<UpdateDonoDto, Dono>();
            CreateMap<Dono, ReadDonoDto>();
        }
    }
}
