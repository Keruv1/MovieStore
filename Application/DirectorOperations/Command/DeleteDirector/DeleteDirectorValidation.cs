using System;
using System.Linq;
using MovieStore.DBOperations;
using FluentValidation;



namespace MovieStore.Application.DirectorOperation.Command.DeleteDirector
{
    public class DeleteDirectorValidation : AbstractValidator<DeleteDirectorCommand>
    {
        public DeleteDirectorValidation()
        {
            RuleFor(cmd => cmd.DirectorId).GreaterThan(0);
        }
    }
}