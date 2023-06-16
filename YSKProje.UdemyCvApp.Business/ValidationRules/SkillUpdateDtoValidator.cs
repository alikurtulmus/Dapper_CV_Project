﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs.SkillDtos;

namespace BusinessLayer.ValidationRules
{
    public class SkillUpdateDtoValidator : AbstractValidator<SkillUpdateDto>
    {
        public SkillUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");
        }
    }
}
