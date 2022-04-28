
using AutoMapper;
using MovieStore.Entities;
using MovieStore.Application.GenreOperation.Query.GetGenres;
using MovieStore.Application.MovieOperation.CreateMovie;
using MovieStore.Application.MovieOperation.Query.GetMovieDetail;
using MovieStore.Application.MovieOperation.Query.GetMovie;
using MovieStore.Application.GenreOperation.Query.GetGenreDetail;
using MovieStore.Application.GenreOperation.Command.CreateGenre;
using MovieStore.Application.ActorOperations.Query.GetActorDetail;
using MovieStore.Application.ActorOperations.Command.CreateActor;
using MovieStore.Application.DirectorOperation.Command.CreateDirector;
using MovieStore.Application.ActorOperations.Query.GetActor;
using MovieStore.Application.DirectorOperation.Query.GetDirector;
using MovieStore.Application.DirectorOperation.Query.GetDirectorDetail;


namespace MovieStore.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateMovieModel, Movie>();
            CreateMap<Movie, CreateMovieModel>()
            .ForMember(dest=> dest.PublishDate, opt=> opt.MapFrom(x=> x.PublishDate.ToString("dd/MM/yyyy")))
            .ForMember(dest => dest.Director, opt => opt.MapFrom(src => $"{src.Director.Name} {src.Director.Surname}"))
            .ForMember(dest => dest.Actor,opt => opt.MapFrom(src => $"{src.Actor.Name} {src.Actor.Surnme} {src.MovieName}"));
           
       
            //Genre
            CreateMap<Genre, GenresViewModel>();
            CreateMap<Genre, GetGenresDetailModel>();
            CreateMap<CreateGenreModel, Genre>();

            //Actor
            CreateMap<Actor, GetActorModel>();
            CreateMap<Actor, GetActorDetailModel>();
            CreateMap<CreateActorModel, Actor>();

            //Director
            CreateMap<Director, GetDirectorModel>();
            CreateMap<Director, GetDirectorDetailModel>();
            CreateMap<GetDirectorModel, Director>();
        }
    }
}