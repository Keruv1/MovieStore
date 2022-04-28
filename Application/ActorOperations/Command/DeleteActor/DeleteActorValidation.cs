using System;
using System.Linq;
using MovieStore.DBOperations;
using FluentValidation;



namespace MovieStore.Application.ActorOperations.Command.DeleteActor
{
    public class DeleteActorCommandValidator : AbstractValidator<DeleteActorCommand>
    {
        public DeleteActorCommandValidator()
        {
            // RuleFor(Command => Command.Id).GreaterThan(0);
        }
    }
}