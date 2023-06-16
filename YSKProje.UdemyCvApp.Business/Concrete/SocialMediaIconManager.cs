using System;
using System.Collections.Generic;
using System.Text;
using BusinessLayer.Interfaces;
using DataAccessLayer.Interfaces;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class SocialMediaIconManager : GenericManager<SocialMediaIcon>, ISocialMediaIconService
    {
       private readonly IGenericRepository<SocialMediaIcon> _genericSocialMediaIconRepository;

        private readonly ISocialMediaIconRepository _socialMediaIconRepository;
        public SocialMediaIconManager(IGenericRepository<SocialMediaIcon> genericSocialMediaIconRepository, ISocialMediaIconRepository socialMediaIconRepository ) : base(genericSocialMediaIconRepository)
        {
            _genericSocialMediaIconRepository = genericSocialMediaIconRepository;
            _socialMediaIconRepository = socialMediaIconRepository;
        }
        public List<SocialMediaIcon> GetByUserId(int userId)
        {
            return _socialMediaIconRepository.GetByUserId(userId);
        }
    }
}
