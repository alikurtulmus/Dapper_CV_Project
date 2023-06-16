using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs.InterestDtos;

namespace BusinessLayer.ValidationRules
{
    public class InterestUpdateDtoValidator : AbstractValidator<InterestUpdateDto>
    {
        public InterestUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
