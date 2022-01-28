using AutoMapper;
using VeiculoApi.Data.Dtos;
using VeiculoApi.Models;

namespace VeiculoApi.Profiles
{
    public class VeiculoProfile : Profile
    {
        public VeiculoProfile()
        {
            CreateMap<CreateVeiculoDto, Veiculo>();
            CreateMap<UpdateVeiculoDto, Veiculo>();
            CreateMap<Veiculo, ReadVeiculoDto>();
        }
    }
}
