using System;
using System.Linq;
using MovieStore.DBOperations;


namespace MovieStore.Application.DirectorOperation.Command.UpdateDirector
{
    public class UpdateDirectorCommand
    {
        public UpdateDirectorModel model;
        public IMovieDBContext _dbcontext;
        public int DirectorId{get;set;}

        public UpdateDirectorCommand(IMovieDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Handle()
        {
            var director = _dbcontext.Directors.SingleOrDefault(x => x.Id == DirectorId);
            if (director != null)
            {
                throw new InvalidOperationException("Director Bulunamadı");
            }
            else if(_dbcontext.Directors.Any(x=> x.Name == model.Name && x.Surname == model.Surname))
            {
                throw new InvalidOperationException("Director Zaten Mevcut");
            }
            else
            {
                director.Name = string.IsNullOrEmpty(model.Name.Trim()) ? director.Name : model.Name;
                director.Surname = string.IsNullOrEmpty(model.Surname.Trim()) ? director.Surname : model.Surname;
                director.BirthOfDate = string.IsNullOrEmpty(model.BirthOfDate.Trim()) ? director.BirthOfDate : Convert.ToDateTime(model.BirthOfDate);
                
            }
        }
    }




    public class UpdateDirectorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthOfDate { get; set; } 
    }
}