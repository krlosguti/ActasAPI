using AutoMapper;
using ActasAPI.Dtos;
using ActasAPI.Models;
namespace ActasAPI.Profiles
{
    public class ActaProfile : Profile
    {
        public ActaProfile()
        {
            CreateMap<Acta, ActaReadDto>();
            CreateMap<Compromiso,CompromisoReadDto>();
            CreateMap<Avance,AvanceReadDto>();
            CreateMap<Responsable,ResponsableReadDto>();

            CreateMap<ActaCreateDto,Acta>();
            CreateMap<CompromisoCreateDto,Compromiso>();
            CreateMap<AvanceCreateDto,Avance>();
            CreateMap<ResponsableCreateDto,Responsable>();

            CreateMap<ActaUpdateDto,Acta>();
            CreateMap<CompromisoUpdateDto,Compromiso>();
            CreateMap<AvanceUpdateDto,Avance>();
            CreateMap<ResponsableUpdateDto,Responsable>();

            CreateMap<Acta, ActaUpdateDto>();
            CreateMap<Compromiso,CompromisoUpdateDto>();
            CreateMap<Avance,AvanceUpdateDto>();
            CreateMap<Responsable,ResponsableUpdateDto>();
        }
    }
}