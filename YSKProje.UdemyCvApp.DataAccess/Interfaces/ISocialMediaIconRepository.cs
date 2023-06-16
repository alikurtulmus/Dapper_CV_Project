using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Concrete;

namespace DataAccessLayer.Interfaces
{
    public interface ISocialMediaIconRepository : IGenericRepository<SocialMediaIcon>
    {
        List<SocialMediaIcon> GetByUserId(int userId);
    }
}
