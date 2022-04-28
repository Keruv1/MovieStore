using FluentValidation;

namespace MovieStore.Application.GenreOperation.Query.GetGenreDetail
{
    public class GetGenreDetailValidation : AbstractValidator<GetGenreDetail>
    {
        public GetGenreDetailValidation()
        {
            RuleFor(cmd=> cmd.GenreId).GreaterThan(0);
        }
    }
}