using System;
using System.Linq;
using MovieStore.DBOperations;
using FluentValidation;


namespace MovieStore.Application.DirectorOperation.Command.UpdateDirector
{
    public class UpdateDirectorValidation : AbstractValidator<UpdateDirectorCommand>
    {
        public UpdateDirectorValidation()
        {
            RuleFor(cmd => cmd.model.Name).MinimumLength(3);
            RuleFor(cmd => cmd.model.Surname).MinimumLength(3);
        }
    }
}