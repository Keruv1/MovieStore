using System;
using System.Linq;
using MovieStore.DBOperations;



namespace MovieStore.Application.ActorOperations.Command.DeleteActor
{
    public class DeleteActorCommand
    {
        private readonly IMovieDBContext _dbcontext;
        private int ActorId {get;set;}

        public DeleteActorCommand(IMovieDBContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public void Handle()
        {
            var actor = _dbcontext.Actors.SingleOrDefault(x => x.Id == ActorId );
            bool isActorHasBook = _dbcontext.Movies.Any(x=> x.Id == ActorId);
            if (actor != null)
            {
                throw new InvalidOperationException("Aktör Bulunamadı...");
            }
            else if (isActorHasBook)
            {
                throw new InvalidOperationException("Aktörün Filmi Mevcuttur, İlk Önce Aktörün Filmini Silinız.");
            }
            else
            {
                _dbcontext.Actors.Remove(actor);
                _dbcontext.SaveChanges();
            }
        }
    }
}