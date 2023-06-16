using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs.InterestDtos;

namespace BusinessLayer.ValidationRules
{
    public class InterestAddDtoValidator : AbstractValidator<InterestAddDto>
    {
        public InterestAddDtoValidator()
        {
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
