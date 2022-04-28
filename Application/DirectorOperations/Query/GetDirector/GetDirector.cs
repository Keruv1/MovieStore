using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MovieStore.DBOperations;


namespace MovieStore.Application.DirectorOperation.Query.GetDirector
{
    public class GetDirector
    {
        private readonly IMapper _mapper;
        private readonly IMovieDBContext _dbcontext;
        public GetDirector(IMapper mapper, IMovieDBContext dBContext)
        {
            _dbcontext = dBContext;
            _mapper = mapper;
        }

        public List<GetDirectorModel> Handle()
        {
            var director = _dbcontext.Directors.OrderBy(x => x.Id);
             List<GetDirectorModel> vm = _mapper.Map<List<GetDirectorModel>>(director);
            return vm;
        }

    }

    public class GetDirectorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthOfDate { get; set; } 
    }
}