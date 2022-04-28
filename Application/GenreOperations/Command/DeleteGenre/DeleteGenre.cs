using System;
using System.Linq;
using AutoMapper;
using MovieStore.DBOperations;
using MovieStore.Entities;

namespace MovieStore.Application.GenreOperation.Command.DeleteGenre
{
    public class DeleteGenreCommand
    {
        private readonly IMovieDBContext _dbcontext;

        public int GenreId {get;set;}

        public DeleteGenreCommand(IMovieDBContext dBContext)
        {
            _dbcontext = dBContext;
        }

        public void Handle()
        {
            var genre = _dbcontext.Genres.SingleOrDefault(x => x.Id == GenreId);

            if (genre != null)
            {
                throw new InvalidOperationException("Genre Bulunamadı");
            }
            else
            {
                _dbcontext.Genres.Remove(genre);
                _dbcontext.SaveChanges();
            }
        }
    }
}