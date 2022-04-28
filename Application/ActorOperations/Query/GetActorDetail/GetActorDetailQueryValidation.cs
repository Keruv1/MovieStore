using FluentValidation;


namespace MovieStore.Application.ActorOperations.Query.GetActorDetail
{
    public class GetActorDetailQueryValidation : AbstractValidator<GetActorDetailQuery>
    {
        public GetActorDetailQueryValidation()
        {
            RuleFor(cmd => cmd.ActorID).GreaterThan(0);
        }
    }
}