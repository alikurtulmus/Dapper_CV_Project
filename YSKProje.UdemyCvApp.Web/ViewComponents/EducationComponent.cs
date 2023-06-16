using AutoMapper;
using BusinessLayer.Interfaces;
using DTO.DTOs.EducationDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace UILayer.ViewComponents
{
    public class EducationComponent : ViewComponent
    {
        private readonly IGenericService<Education> _genericEducationService;
        private readonly IMapper _mapper;

        public EducationComponent(IGenericService<Education> genericEducationService, IMapper mapper)
        {
            _genericEducationService = genericEducationService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<EducationListDto>>(_genericEducationService.GetAll()));
        }
    }
}
