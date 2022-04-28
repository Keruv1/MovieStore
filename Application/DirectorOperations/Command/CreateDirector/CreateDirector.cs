using System;
using System.Linq;
using AutoMapper;
using MovieStore.DBOperations;
using MovieStore.Entities;


namespace MovieStore.Application.DirectorOperation.Command.CreateDirector
{
    public class CreateDirectorCommand
    {
        public CreateDirectorCommandModel model;
        
        private readonly IMovieDBContext _dbcontext;
        private readonly IMapper _mapper;

        public CreateDirectorCommand(IMovieDBContext dBContext, IMapper mapper)
        {
            _dbcontext = dBContext;
            _mapper = mapper;
        }

        public void Handle()
        {
            var director = _dbcontext.Directors.SingleOrDefault(x => x.Name == model.Name && x.Surname == model.Surname && x.BirthOfDate == Convert.ToDateTime(model.BirthOfDate));
            if (director != null)
            {
                throw new InvalidOperationException("Director Bulunamadı");
            }
            else
            {
                director = _mapper.Map<Director>(model);
                _dbcontext.Directors.Add(director);
                _dbcontext.SaveChanges();
            }
        }
    }


    public class CreateDirectorCommandModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthOfDate { get; set; }
    }
}