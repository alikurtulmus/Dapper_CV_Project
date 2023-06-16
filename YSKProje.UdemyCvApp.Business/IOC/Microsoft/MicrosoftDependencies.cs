using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using BusinessLayer.Concrete;
using BusinessLayer.Interfaces;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.Dapper;
using DataAccessLayer.Interfaces;
using DTO.DTOs.AppUserDtos;
using DTO.DTOs.CertificationDtos;
using DTO.DTOs.EducationDtos;
using DTO.DTOs.ExperienceDtos;
using DTO.DTOs.InterestDtos;
using DTO.DTOs.SkillDtos;
using DTO.DTOs.SocialMediaIconDtos;

namespace BusinessLayer.IOC.Microsoft
{
    public static class MicrosoftDependencies
    {
        public static void AddCustomDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDbConnection>(con => new SqlConnection(configuration.GetConnectionString("connectionMssql")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(DpGenericRepository<>));
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

            services.AddScoped<IAppUserRepository, DpAppUserRepository>();
            services.AddScoped<IAppUserService, AppUserManager>();

            services.AddScoped<ISocialMediaIconRepository, DpSocialMediaIconRepository>();
            services.AddScoped<ISocialMediaIconService, SocialMediaIconManager>();


            services.AddTransient<IValidator<AppUserUpdateDto>, AppUserUpdateDtoValidator>();
            services.AddTransient<IValidator<AppUserPasswordDto>, AppUserPasswordDtoValidator>();
            services.AddTransient<IValidator<CertificationAddDto>, CertificationAddDtoValidator>();
            services.AddTransient<IValidator<CertificationUpdateDto>, CertificationUpdateDtoValidator>();
            services.AddTransient<IValidator<EducationAddDto>, EducationAddDtoValidator>();
            services.AddTransient<IValidator<EducationUpdateDto>, EducationUpdateDtoValidator>();
            services.AddTransient<IValidator<ExperienceAddDto>, ExperienceAddDtoValidator>();
            services.AddTransient<IValidator<ExperienceUpdateDto>, ExperienceUpdateDtoValidator>();
            services.AddTransient<IValidator<InterestAddDto>, InterestAddDtoValidator>();
            services.AddTransient<IValidator<InterestUpdateDto>, InterestUpdateDtoValidator>();
            services.AddTransient<IValidator<SkillAddDto>, SkillAddDtoValidator>();
            services.AddTransient<IValidator<SkillUpdateDto>, SkillUpdateDtoValidator>();
            services.AddTransient<IValidator<SocialMediaIconAddDto>, SocialMediaIconAddDtoValidator>();
            services.AddTransient<IValidator<SocialMediaIconUpdateDto>, SocialMediaIconUpdateDtoValidator>();
         
        }
    }
}
