using System;
using System.Linq;
using AutoMapper;
using MovieStore.DBOperations;
using MovieStore.Entities;
using FluentValidation;


namespace MovieStore.Application.ActorOperations.Command.CreateActor
{
    public class CreateActorValidation : AbstractValidator<CreateActorCommand>
    {
        public CreateActorValidation()
        {
            RuleFor(cmd => cmd.model.Name).NotEmpty().MinimumLength(4);
            RuleFor(cmd => cmd.model.Surname).NotEmpty().MinimumLength(3);
        }
        
    }
}