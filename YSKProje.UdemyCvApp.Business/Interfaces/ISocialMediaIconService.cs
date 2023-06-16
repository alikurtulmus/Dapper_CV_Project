using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Concrete;

namespace BusinessLayer.Interfaces
{
    public interface ISocialMediaIconService : IGenericService<SocialMediaIcon>
    {
        List<SocialMediaIcon> GetByUserId(int userId);
    }
}
