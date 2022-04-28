using System;
using System.Linq;
using AutoMapper;
using MovieStore.DBOperations;
using MovieStore.Entities;

namespace MovieStore.Application.GenreOperation.Command.CreateGenre
{

    public class CreateGenreCommand
    {
         public CreateGenreModel model { get; set; }
        private readonly IMovieDBContext _dbcontext;
        private readonly IMapper _mapper;

        public CreateGenreCommand(IMovieDBContext dBContext, IMapper mapper)
        {
            _dbcontext = dBContext;
            _mapper = mapper;
        }

        public void Handle()
        {
            var genre = _dbcontext.Genres.SingleOrDefault(x=> x.Name == model.Name );
            if (genre!= null)
            {
                throw new InvalidOperationException("Genre Mevcut");
            }
            else
            {
                genre = _mapper.Map<Genre>(model);
                _dbcontext.Genres.AddRange(genre);
                _dbcontext.SaveChanges();
            }
        }
    }



    public class CreateGenreModel
    {
        public string Name { get; set; }
    }

}