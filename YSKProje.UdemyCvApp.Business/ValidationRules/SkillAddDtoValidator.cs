using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs.SkillDtos;

namespace BusinessLayer.ValidationRules
{
    public class SkillAddDtoValidator : AbstractValidator<SkillAddDto>
    {
        public SkillAddDtoValidator()
        {
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
