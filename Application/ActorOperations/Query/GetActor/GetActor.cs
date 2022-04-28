using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MovieStore.DBOperations;


namespace MovieStore.Application.ActorOperations.Query.GetActor
{
    public class GetActor
    {
        private readonly IMapper _mapper;
        private readonly IMovieDBContext _dbcontext;



        public GetActor(IMapper mapper, IMovieDBContext dBContext)
        {
            _dbcontext = dBContext;
            _mapper = mapper;
        }


        public List<GetActorModel> Handle()
        {
            var actor = _dbcontext.Actors.OrderBy(x=> x.Id);
            List<GetActorModel> vm = _mapper.Map<List<GetActorModel>>(actor);
            return vm;
        }
    }



    public class GetActorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthOfDate { get; set; }
    }
}