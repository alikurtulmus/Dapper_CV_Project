using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO.DTOs.AppUserDtos;
using DTO.DTOs.CertificationDtos;
using DTO.DTOs.EducationDtos;
using DTO.DTOs.ExperienceDtos;
using DTO.DTOs.InterestDtos;
using DTO.DTOs.SkillDtos;
using DTO.DTOs.SocialMediaIconDtos;
using EntityLayer.Concrete;

namespace YSKProje.UdemyCvApp.Web.Mapping
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AppUser, AppUserListDto>();
            CreateMap<AppUserListDto, AppUser>();

            CreateMap<Certification, CertificationListDto>();
            CreateMap<CertificationListDto, Certification>();
            CreateMap<CertificationAddDto, Certification>();
            CreateMap<Certification, CertificationAddDto>();
            CreateMap<CertificationUpdateDto, Certification>();
            CreateMap<Certification, CertificationUpdateDto>();


            CreateMap<Education, EducationListDto>();
            CreateMap<EducationListDto, Education>();
            CreateMap<EducationAddDto, Education>();
            CreateMap<Education, EducationAddDto>();
            CreateMap<Education, EducationUpdateDto>();
            CreateMap<EducationUpdateDto, Education>();


            CreateMap<Experience, ExperienceListDto>();
            CreateMap<ExperienceListDto, Experience>();
            CreateMap<Experience, ExperienceAddDto>();
            CreateMap<ExperienceAddDto, Experience>();
            CreateMap<Experience, ExperienceUpdateDto>();
            CreateMap<ExperienceUpdateDto, Experience>();


            CreateMap<Interest, InterestListDto>();
            CreateMap<InterestListDto, Interest>();
            CreateMap<Interest, InterestAddDto>();
            CreateMap<InterestAddDto, Interest>();
            CreateMap<Interest, InterestUpdateDto>();
            CreateMap<InterestUpdateDto, Interest>();


            CreateMap<Skill, SkillListDto>();
            CreateMap<SkillListDto, Skill>();
            CreateMap<Skill, SkillAddDto>();
            CreateMap<SkillAddDto, Skill>();
            CreateMap<Skill, SkillUpdateDto>();
            CreateMap<SkillUpdateDto, Skill>();


            CreateMap<SocialMediaIcon, SocialMediaIconListDto>();
            CreateMap<SocialMediaIconListDto, SocialMediaIcon>();
            CreateMap<SocialMediaIcon, SocialMediaIconAddDto>();
            CreateMap<SocialMediaIconAddDto, SocialMediaIcon>();
            CreateMap<SocialMediaIcon, SocialMediaIconUpdateDto>();
            CreateMap<SocialMediaIconUpdateDto, SocialMediaIcon>();
        }
    }
}
