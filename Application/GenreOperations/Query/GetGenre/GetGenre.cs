using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MovieStore.DBOperations;


namespace MovieStore.Application.GenreOperation.Query.GetGenres
{
    public class GetGenresQuery
    {
        public GenresViewModel model;
        private readonly IMovieDBContext _dbcontext;
        private readonly IMapper _mapper;

        public GetGenresQuery(IMovieDBContext dBContext, IMapper mapper)
        {
            _dbcontext = dBContext;
            _mapper = mapper;
        }

        public List<GenresViewModel> Handle()
        {
            var genres = _dbcontext.Genres.Where(x=> x.Id == model.Id);
            List<GenresViewModel> vm = _mapper.Map<List<GenresViewModel>>(genres);
            return vm;
        }

    }

    public class GenresViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }    
    }
}