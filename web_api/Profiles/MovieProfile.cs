using AutoMapper;
using web_api.Data;
using web_api.Models;

namespace web_api.Profiles
{
   public class MovieProfile : Profile
   {
    public MovieProfile()
    {
        CreateMap<CreateMovieDto, Movie>();
        CreateMap<Movie, GetMovieDto>();
        CreateMap<UpdateMovieDto, Movie>();
    }
   } 
}