using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs.CertificationDtos;

namespace BusinessLayer.ValidationRules
{
    public class CertificationUpdateDtoValidator : AbstractValidator<CertificationUpdateDto>
    {
        public CertificationUpdateDtoValidator()
        {
            RuleFor(I => I.Id).InclusiveBetween(1, int.MaxValue).WithMessage("Id alanı boş geçilemez");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Sertifika boş geçilemez");
        }
    }
}
