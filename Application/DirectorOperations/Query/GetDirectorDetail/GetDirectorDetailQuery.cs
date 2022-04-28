using System;
using System.Linq;
using AutoMapper;
using MovieStore.DBOperations;




namespace MovieStore.Application.DirectorOperation.Query.GetDirectorDetail
{
    public class GetDirectorDetailQuery
    {
        private readonly IMovieDBContext _dbcontext;
        private readonly IMapper _mapper;
        
        public int DirectorID { get; set; }


        public GetDirectorDetailQuery(IMovieDBContext dbcontext, IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }

        public GetDirectorDetailModel Handle()
        {
            var director =_dbcontext.Directors.SingleOrDefault(x=> x.Id == DirectorID);

            if (director != null)
            {
                throw new InvalidOperationException("Director Bulunamadı");
            }
            else
            {
                GetDirectorDetailModel vm = new GetDirectorDetailModel();
                return vm;
            }
        }

    }


    public class GetDirectorDetailModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthOfDate { get; set; }
    }
}