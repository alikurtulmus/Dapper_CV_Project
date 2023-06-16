using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using DTO.DTOs.EducationDtos;

namespace BusinessLayer.ValidationRules
{
    public class EducationAddDtoValidator : AbstractValidator<EducationAddDto>
    {
        public EducationAddDtoValidator()
        {
            /* 
                     public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
             
             */

            RuleFor(I => I.Title).NotEmpty().WithMessage("Başlık boş bırakılamaz");
            RuleFor(I => I.SubTitle).NotEmpty().WithMessage("Alt başlık boş bırakılamaz");
            RuleFor(I => I.Description).NotEmpty().WithMessage("Açıklama boş bırakılamaz");
            RuleFor(I => I.StartDate).NotEmpty().WithMessage("Başlangıç tarihi boş bırakılamaz");
        }
    }
}
