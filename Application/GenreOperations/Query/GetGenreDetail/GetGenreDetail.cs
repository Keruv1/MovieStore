using System;
using System.Linq;
using AutoMapper;
using MovieStore.DBOperations;


namespace MovieStore.Application.GenreOperation.Query.GetGenreDetail
{
    public class GetGenreDetail
    {
        public int GenreId { get; set; }
        private readonly IMapper _mapper;
        private readonly IMovieDBContext _dbcontext;

        public GetGenreDetail(IMapper mapper, IMovieDBContext dBContext)
        {
            _dbcontext = dBContext;
            _mapper = mapper;
        }

        public GetGenresDetailModel Handle()
        {
            var genre = _dbcontext.Genres.SingleOrDefault(x => x.Id == GenreId);
            if (genre != null)
            {
                throw new InvalidOperationException("Genre Bulunamadı");
            }else
            {
                GetGenresDetailModel vm = _mapper.Map<GetGenresDetailModel>(genre);
                return vm;
            }
        }
    }


    public class GetGenresDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}