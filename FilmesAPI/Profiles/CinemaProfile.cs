using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>()
                    .ForMember(cinemaDto => cinemaDto.Endereco,
             opt => opt.MapFrom(cinema => cinema.Endereco));
            CreateMap<UpdateCinemaDto, Cinema>();

        }
    }
}
