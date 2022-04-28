using FluentValidation;


namespace MovieStore.Application.MovieOperation.CreateMovie
{
    public class CreateMovieValidation : AbstractValidator<CreateMovieCommand>
    {
        public CreateMovieValidation()
        {
            RuleFor(cmd=> cmd.model.Name).NotEmpty().MinimumLength(4);
            RuleFor(cmd => cmd.model.Genre).NotEmpty().MinimumLength(3);
            RuleFor(cmd  => cmd.model.PublishDate).NotEmpty();
        }
    }
}