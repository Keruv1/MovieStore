using System;
using System.Linq;
using AutoMapper;
using MovieStore.DBOperations;
using MovieStore.Entities;


namespace MovieStore.Application.MovieOperation.CreateMovie
{
    public class CreateMovieCommand
    {
        public CreateMovieModel model;
        private readonly IMovieDBContext _dbcontext;
        private readonly IMapper _mapper;

        public CreateMovieCommand( IMapper mapper, IMovieDBContext dBContext)
        {
            _dbcontext = dBContext;
            _mapper = mapper;
        }

        public void Handle()
        {
            var movie = _dbcontext.Movies.SingleOrDefault(x=> x.MovieName == model.Name);
            if (movie != null)
            {
                throw new InvalidOperationException("Film Zaten Mevcut");
            }
            else
            {
                movie = _mapper.Map<Movie>(model);
                _dbcontext.Movies.Add(movie);
                _dbcontext.SaveChanges();
            }
        }
    }

    public class CreateMovieModel
    {
     public string Name { get; set; }
        public string Genre { get; set; }
        public string Actor { get; set; }
        public string Director { get; set; }
        public DateTime PublishDate { get; set; }
    }
}