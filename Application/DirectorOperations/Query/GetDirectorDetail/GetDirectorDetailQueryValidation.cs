using FluentValidation;




namespace MovieStore.Application.DirectorOperation.Query.GetDirectorDetail
{
    public class GetDirectorDetailValidation : AbstractValidator<GetDirectorDetailQuery>
    {
        public GetDirectorDetailValidation()
        {
            RuleFor(cmd=> cmd.DirectorID).GreaterThan(0);
        }
    }
}