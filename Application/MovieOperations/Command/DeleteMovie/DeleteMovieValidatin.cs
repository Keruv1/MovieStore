using FluentValidation;

namespace MovieStore.Application.MovieOperation.DeleteMovie
{
    public class DeleteMovieValidation : AbstractValidator<DeleteMovieCommand>
    {
        public DeleteMovieValidation()
        {
            RuleFor(cmd => cmd.MovieId).GreaterThan(0);
        }
    }
}