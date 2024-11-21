using AutoMapper;
using Models;
using MoviesApi.Dtos;

namespace MoviesApi.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieDetailsDto>();
            CreateMap<MovieDto, Movie>()
                .ForMember(dest => dest.Poster, opt => opt.Ignore());
        }
    }
}
