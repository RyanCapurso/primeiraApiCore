using AutoMapper;
using primeiraApiCore.Data.Dtos;
using primeiraApiCore.models;


namespace FilmesApi.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>();

            CreateMap<Cinema, ReadCinemaDto>()
            .ForMember(dto => dto.ReadEnderecoDto, opt => opt.MapFrom(cinema => cinema.Endereco))
            .ForMember(dto => dto.Sessoes, opt => opt.MapFrom(cinema => cinema.Sessoes));
        }
    }
}