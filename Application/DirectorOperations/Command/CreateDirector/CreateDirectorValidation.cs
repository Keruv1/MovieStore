using FluentValidation;


namespace MovieStore.Application.DirectorOperation.Command.CreateDirector
{
   public class CreateDirectorValidation :AbstractValidator<CreateDirectorCommand>
   {
       public CreateDirectorValidation()
       {
           RuleFor(cmd => cmd.model.Name).NotEmpty().MinimumLength(3);
           RuleFor(cmd => cmd.model.Surname).NotEmpty().MinimumLength(3);
       }
   }
}