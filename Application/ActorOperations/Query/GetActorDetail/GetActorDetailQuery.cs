using System;
using System.Linq;
using AutoMapper;
using MovieStore.DBOperations;




namespace MovieStore.Application.ActorOperations.Query.GetActorDetail
{
    public class GetActorDetailQuery
    {
        private readonly IMovieDBContext _dbcontext;
        private readonly IMapper _mapper;
        public int ActorID{get;set;}

        public GetActorDetailQuery(IMovieDBContext dBContext, IMapper mapper)
        {
            _dbcontext = dBContext;
            _mapper = mapper;
        }

        public GetActorDetailModel Handle()
        {
            var actor = _dbcontext.Actors.SingleOrDefault(x => x.Id == ActorID ) ;
            if (actor != null)
            {
                throw new InvalidOperationException("Aktör Bulunamadı");
            }
            else
            {
                GetActorDetailModel vm = _mapper.Map<GetActorDetailModel>(actor);
                return vm;
            }
        }

    }



    public class GetActorDetailModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthOfDate { get; set; }
    }
}