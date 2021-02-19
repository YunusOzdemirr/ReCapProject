using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.BrandId).NotEmpty().WithMessage("Marka Id zorunludur");
            RuleFor(c => c.BrandId).GreaterThan(0).WithMessage("Marka Id 0'dan büyük olmalıdır");
            RuleFor(c => c.ColorId).NotEmpty().WithMessage("Renk Id zorunludur");
            RuleFor(c => c.BrandId).GreaterThan(0).WithMessage("Color Id 0'dan büyük olmalıdır");
            RuleFor(c => c.DailyPrice).NotEmpty().WithMessage("Günlük ücret zorunludur");
            RuleFor(c => c.BrandId).GreaterThan(0).WithMessage("Günlük ücret Id 0'dan büyük olmalıdır");
            RuleFor(c => c.Description).MaximumLength(10).WithMessage("Açıklama alanı maksimum 10 karakter olmalıdır");
            RuleFor(c => c.ModelYear).GreaterThanOrEqualTo(1900).WithMessage("Araç modeli 1900 yılından eski olamaz");

        }
    }
}
