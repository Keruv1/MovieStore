using System;
using System.Linq;
using MovieStore.DBOperations;


namespace MovieStore.Application.MovieOperation.DeleteMovie
{
    public class DeleteMovieCommand
    {
        private readonly IMovieDBContext _dbcontext;

        public int MovieId { get; set; }
        public DeleteMovieCommand(IMovieDBContext dBContext)
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
            else
            {
                _dbcontext.Movies.Remove(movie);
                _dbcontext.SaveChanges();
            }
        }
    }
}