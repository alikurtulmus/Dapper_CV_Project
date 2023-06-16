using AutoMapper;
using BusinessLayer.Interfaces;
using DTO.DTOs.CertificationDtos;
using DTO.DTOs.SkillDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace UILayer.ViewComponents
{
    public class AwardComponent : ViewComponent
    {
        private readonly IGenericService<Certification> _genericCertificationService;
        private readonly IMapper _mapper;

        public AwardComponent(IGenericService<Certification> genericCertificationService, IMapper mapper)
        {
            _genericCertificationService = genericCertificationService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<CertificationListDto>>(_genericCertificationService.GetAll()));
        }
    }
}