using AutoMapper;
using BusinessLayer.Interfaces;
using DTO.DTOs.InterestDtos;
using DTO.DTOs.SkillDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace UILayer.ViewComponents
{

    public class InterestComponent : ViewComponent
    {
        private readonly IGenericService<Interest> _genericInterestService;
        private readonly IMapper _mapper;

        public InterestComponent(IGenericService<Interest> genericInterestService, IMapper mapper)
        {
            _genericInterestService = genericInterestService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            return View(_mapper.Map<List<InterestListDto>>(_genericInterestService.GetAll()));
        }
    }
}