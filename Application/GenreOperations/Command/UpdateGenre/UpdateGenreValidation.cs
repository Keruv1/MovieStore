using FluentValidation;

namespace MovieStore.Application.GenreOperation.Command.UpdateGenre
{
    public class UpdateGenreValidation : AbstractValidator<UpdateGenreCommand>
    {
        public UpdateGenreValidation()
        {
            RuleFor(cmd => cmd.model.Name).MinimumLength(3);
        }
    }
}