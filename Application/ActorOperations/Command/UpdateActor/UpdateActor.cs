using System;
using System.Linq;
using MovieStore.DBOperations;


namespace MovieStore.Application.ActorOperations.Command.UpdateActor
{
    public class UpdateActorCommand
    {
        public  UpdateActorCommandModel model;
        private readonly IMovieDBContext _dbcontext;
        public int ActorId{get;set;}


        public UpdateActorCommand(IMovieDBContext dBContext)
        {
            _dbcontext = dBContext;
        }


        public void Handle()
        {
            var actor = _dbcontext.Actors.SingleOrDefault(x => x.Name == model.Name);
            if (actor != null)
            {
                throw new InvalidOperationException("Aktör Bulunamadı");
            }
            else if(_dbcontext.Actors.Any(x => x.Name.ToLower() == model.Name.ToLower() && x.Surnme.ToLower() == model.Surname.ToLower() ))
            {
                throw new InvalidOperationException("Aktör Zaten Mevcut");
            }
            else
            {
                actor.Name = string.IsNullOrEmpty(model.Name.Trim()) ? actor.Name : model.Name;
                actor.Surnme = string.IsNullOrEmpty(model.Surname.Trim()) ? actor.Surnme : model.Surname;
                actor.BirthOfDate = string.IsNullOrEmpty(model.BirthOfDate.Trim()) ? actor.BirthOfDate : Convert.ToDateTime(model.BirthOfDate);
            }
        }
    }


    public class UpdateActorCommandModel
    {
        public string Name {get;set;}
        public string Surname {get;set;}
        public string BirthOfDate {get;set;}
    }
}