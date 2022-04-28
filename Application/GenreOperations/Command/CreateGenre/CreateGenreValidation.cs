using System;
using System.Linq;
using AutoMapper;
using MovieStore.DBOperations;
using MovieStore.Entities;
using FluentValidation;

namespace MovieStore.Application.GenreOperation.Command.CreateGenre
{
    public class CreateGenreValidation : AbstractValidator<CreateGenreCommand>
    {
        public CreateGenreValidation()
        {
            RuleFor(cmd=> cmd.model.Name).MinimumLength(2);
        }
    }
}