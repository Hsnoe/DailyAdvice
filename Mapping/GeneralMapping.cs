using AutoMapper;
using DailyAdvice.Dtos.MovieDtos;
using DailyAdvice.Entities;

namespace DailyAdvice.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping() 
        {
            CreateMap<CreateMovieDto, Movie>().ReverseMap();
            CreateMap<UpdateMovieDto, Movie>().ReverseMap();
            CreateMap<GetMovieByIdDto, Movie>().ReverseMap();
            CreateMap<GetMovieDto, Movie>().ReverseMap();
        }
    }
}
