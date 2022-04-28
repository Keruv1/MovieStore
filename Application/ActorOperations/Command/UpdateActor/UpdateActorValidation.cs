using System;
using System.Linq;
using MovieStore.DBOperations;
using FluentValidation;


namespace MovieStore.Application.ActorOperations.Command.UpdateActor
{
    public class UpdateActorCommandValidation : AbstractValidator<UpdateActorCommand>
    {
        public UpdateActorCommandValidation()
        {
            RuleFor(cmd => cmd.model.Name).MinimumLength(3);
            RuleFor(cmd => cmd.model.Surname).MinimumLength(3);
            //hata verirse buraya bak.
        }
    }
}