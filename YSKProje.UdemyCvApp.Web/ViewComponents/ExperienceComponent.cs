using AutoMapper;
using BusinessLayer.Interfaces;
using DataAccessLayer.Interfaces;
using DTO.DTOs.ExperienceDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace UILayer.ViewComponents
{
    public class ExperienceComponent : ViewComponent
    {
        private readonly IGenericService<Experience> _genericExperienceService;
        private readonly IMapper _mapper;

        public ExperienceComponent(IGenericService<Experience> genericExperienceService, IMapper mapper)
        {
            _genericExperienceService = genericExperienceService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<ExperienceListDto>>(_genericExperienceService.GetAll()));
        }
    }
}
