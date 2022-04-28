using FluentValidation;

namespace MovieStore.Application.MovieOperation.UpdateMovie
{
    public class UpdateMovieValidation : AbstractValidator<UpdateMovieCommand>
    {
        public UpdateMovieValidation()
        {
            RuleFor(cmd => cmd.model.Name).MinimumLength(3);
        }
    }
}