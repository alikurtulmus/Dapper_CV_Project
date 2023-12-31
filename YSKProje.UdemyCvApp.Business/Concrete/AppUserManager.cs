﻿using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Interfaces;
using DataAccessLayer.Interfaces;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class AppUserManager : GenericManager<AppUser>, IAppUserService
    {

        private readonly IGenericRepository<AppUser> _genericRepository;
        private readonly IAppUserRepository _appUserRepository;
        public AppUserManager(IGenericRepository<AppUser> genericRepository, IAppUserRepository appUserRepository) : base(genericRepository)
        {
            _genericRepository = genericRepository;
            _appUserRepository = appUserRepository;
        }
        public bool ChekUser(string userName, string password)
        {
            return _appUserRepository.ChekUser(userName,password);
        }

        public AppUser FindByName(string userName)
        {
            return _appUserRepository.FindByName(userName);
        }
    }
}
