using FluentValidation;

namespace MovieStore.Application.GenreOperation.Command.DeleteGenre
{
    public class DeleteGenreValidation : AbstractValidator<DeleteGenreCommand>
    {
        public DeleteGenreValidation()
        {
            RuleFor(cmd => cmd.GenreId).GreaterThan(0);
        }
    }
}