using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs.CertificationDtos;

namespace BusinessLayer.ValidationRules
{
    public class CertificationAddDtoValidator :AbstractValidator<CertificationAddDto>
    {
        public CertificationAddDtoValidator()
        {
            RuleFor(I => I.Description).NotEmpty().WithMessage("Sertifika alanı boş geçilemez");
        }
    }
}
