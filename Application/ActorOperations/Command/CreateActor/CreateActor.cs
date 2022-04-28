using System;
using System.Linq;
using AutoMapper;
using MovieStore.DBOperations;
using MovieStore.Entities;


namespace MovieStore.Application.ActorOperations.Command.CreateActor
{
    public class CreateActorCommand
    {
        public CreateActorModel model;
        private readonly IMovieDBContext _dbcontext;
        private readonly IMapper _mapper;

        public CreateActorCommand(IMovieDBContext dbcontext, IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }

        public void Handle()
        {
            var actor = _dbcontext.Actors.SingleOrDefault(x => x.Name == model.Name && x.Surnme == model.Surname);
            if (actor != null )
            {
                throw new InvalidOperationException("Aktör Zaten Mevcut");
            }
            else
            {
                actor = _mapper.Map<Actor>(model);
                _dbcontext.Actors.Add(actor);
                _dbcontext.SaveChanges();
            }
            
        }    
    }


}

 public class CreateActorModel
    {
        public string Name {get;set;}
        public string Surname {get;set;}
        public string BirthOfDate {get;set;}

}