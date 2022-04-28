using System;
using System.Linq;
using AutoMapper;
using MovieStore.DBOperations;
using MovieStore.Entities;

namespace MovieStore.Application.GenreOperation.Command.UpdateGenre
{
    public class UpdateGenreCommand
    {
        public UpdateGenreModel model;
        public int GenreId { get; set; }
        private readonly IMovieDBContext _dbcontext;

        public UpdateGenreCommand(IMovieDBContext dBContext)
        {
            _dbcontext = dBContext;
        }


        public void Handle()
        {
            var genre = _dbcontext.Genres.SingleOrDefault(x=> x.Id == GenreId);
            if (genre != null)
            {
                throw new InvalidOperationException("Genre Mevcut Değil");
            }
            else if(_dbcontext.Genres.Any(x => x.Name.ToLower() == model.Name.ToLower() && x.Id != GenreId))
            {
                 throw new InvalidOperationException("Aynı İsimli Genre Zaten Mevcut.");
            }
            else
            {
                genre.Name = string.IsNullOrEmpty(model.Name.Trim()) ? genre.Name : model.Name;
                _dbcontext.SaveChanges();
            }
        }
    }



    public class UpdateGenreModel
    {
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
    }
}