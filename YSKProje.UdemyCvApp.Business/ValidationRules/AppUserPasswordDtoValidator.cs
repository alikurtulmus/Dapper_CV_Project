using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs.AppUserDtos;

namespace BusinessLayer.ValidationRules
{
    public class AppUserPasswordDtoValidator : AbstractValidator<AppUserPasswordDto>
    {
        public AppUserPasswordDtoValidator()
        {
            RuleFor(I => I.Password).NotEmpty().WithMessage("Parola boş geçilemez");
            RuleFor(I => I.CofirmPassword).NotEmpty().WithMessage("Parola tekrar boş geçilemez");
            RuleFor(I => I.CofirmPassword).Equal(I => I.Password).WithMessage("Parolalar uyuşmuyor");
        }
    }
}
