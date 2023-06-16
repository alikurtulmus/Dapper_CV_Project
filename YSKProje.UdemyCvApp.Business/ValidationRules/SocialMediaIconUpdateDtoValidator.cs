using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs.SocialMediaIconDtos;

namespace BusinessLayer.ValidationRules
{
    public class SocialMediaIconUpdateDtoValidator : AbstractValidator<SocialMediaIconUpdateDto>
    {
        public SocialMediaIconUpdateDtoValidator()
        {
           
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id boş bırakılamaz");

            RuleFor(I => I.Icon).NotEmpty().WithMessage("İkon boş bırakılamaz");
            RuleFor(I => I.Link).NotEmpty().WithMessage("Link boş bırakılamaz");
        }
    }
}
