using AutoMapper;
using primeiraApiCore.Data.Dtos;
using primeiraApiCore.models;

namespace primeiraApiCore.Profiles;

public class CinemaProfile : Profile
{
    public CinemaProfile()
	{
		CreateMap<CreateCinemaDto, Cinema>();
        CreateMap<UpdateCinemaDto, Cinema>();
        CreateMap<Cinema, UpdateCinemaDto>();
        CreateMap<Cinema, ReadCinemaDto>()
        .ForMember(dto => dto.ReadEnderecoDto, opt => opt.MapFrom(cinema => cinema.Endereco))
        .ForMember(dto => dto.Sessoes, opt => opt.MapFrom(cinema => cinema.Sessoes));


    
	}
}
