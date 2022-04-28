using System;
using System.Linq;
using MovieStore.DBOperations;



namespace MovieStore.Application.DirectorOperation.Command.DeleteDirector
{
    public class DeleteDirectorCommand
    {
        private readonly IMovieDBContext _dbcontext;
        public int DirectorId{get;set;}

        public DeleteDirectorCommand(IMovieDBContext dBContext)
        {
            _dbcontext = dBContext;
        }


        public void Handle()
        {
            var director = _dbcontext.Directors.SingleOrDefault(x=> x.Id == DirectorId);
            bool isDirectorHasBook = _dbcontext.Movies.Any(x => x.Id == DirectorId);
            if (director != null)
            {
                throw new InvalidOperationException("Director Bulunamadı");
            }
            else if(isDirectorHasBook )
            {
                throw new InvalidOperationException("Director'ün Filmi Mevcuttur.");
            }
            else
            {
                _dbcontext.Directors.Remove(director);
                _dbcontext.SaveChanges();
            }
        }

    }
}