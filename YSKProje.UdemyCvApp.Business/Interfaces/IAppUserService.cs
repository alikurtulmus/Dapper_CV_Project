using System;
using System.Collections.Generic;
using System.Text;
using EntityLayer.Concrete;

namespace BusinessLayer.Interfaces
{
    public interface IAppUserService : IGenericService<AppUser>
    {
        /// <summary>
        ///  Eğer user var ise true döner, yok ise false döner.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        bool ChekUser(string userName, string password);
        AppUser FindByName(string userName);
    }
}
