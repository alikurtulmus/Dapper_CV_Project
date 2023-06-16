using AutoMapper;
using BusinessLayer.Interfaces;
using DTO.DTOs.SkillDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace UILayer.ViewComponents
{
    public class SkillComponent : ViewComponent
    {
        private readonly IGenericService<Skill> _genericSkillService;
        private readonly IMapper _mapper;

        public SkillComponent(IGenericService<Skill> genericSkillService, IMapper mapper)
        {
            _genericSkillService = genericSkillService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<SkillListDto>>(_genericSkillService.GetAll()));
        }
    }
}