using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs.SocialMediaIconDtos;

namespace BusinessLayer.ValidationRules
{
    public class SocialMediaIconAddDtoValidator : AbstractValidator<SocialMediaIconAddDto>
    {
        public SocialMediaIconAddDtoValidator()
        {
           
            RuleFor(I => I.Icon).NotEmpty().WithMessage("İkon boş bırakılamaz");
            RuleFor(I => I.Link).NotEmpty().WithMessage("Link boş bırakılamaz");           
        }
    }
}
