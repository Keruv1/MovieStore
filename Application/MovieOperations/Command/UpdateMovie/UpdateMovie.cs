using System;
using System.Linq;
using MovieStore.DBOperations;


namespace MovieStore.Application.MovieOperation.UpdateMovie
{
    public class UpdateMovieCommand
    {

        public UpdateMovieModel model;
        public readonly IMovieDBContext _dbcontext;
        public int MovieId {get;set;}

        public UpdateMovieCommand(IMovieDBContext dBContext)
        {
            _dbcontext = dBContext;
        }

        public void Handle()
        {
            var movie = _dbcontext.Movies.SingleOrDefault(x=> x.Id == MovieId);
            if (movie != null)
            {
                throw new InvalidOperationException("Film Bulunamadı");
            }
            else if(_dbcontext.Movies.Any(x => x.MovieName.ToLower() == model.Name.ToLower() && x.Id != MovieId))
            {
                throw new InvalidOperationException("Aynı Film Zaten Mevcut");
            }
            else
            {
                movie.MovieName = string.IsNullOrEmpty(model.Name.Trim()) ? movie.MovieName : model.Name;
               // movie.Director = string.IsNullOrEmpty(model.director.Trim()) ? movie.Director : model.director;
            }
        }




    }

    public class UpdateMovieModel
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Actor { get; set; }
        public string director { get; set; }
        public DateTime Year { get; set; }
    }
}
