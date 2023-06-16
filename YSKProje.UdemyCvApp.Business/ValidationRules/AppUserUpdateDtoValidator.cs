using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs.AppUserDtos;

namespace BusinessLayer.ValidationRules
{
    public class AppUserUpdateDtoValidator : AbstractValidator<AppUserUpdateDto>
    {
        public AppUserUpdateDtoValidator()
        {

            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
         
        }
    }
}
