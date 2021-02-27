using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator:AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(b => b.ColorId).NotEmpty();
            RuleFor(b => b.Name).NotEmpty();
            RuleFor(b => b.Name).MaximumLength(30);
        }
    }
}
