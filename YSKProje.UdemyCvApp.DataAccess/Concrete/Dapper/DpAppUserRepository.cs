using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataAccessLayer.Interfaces;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.Dapper
{
    public class DpAppUserRepository : DpGenericRepository<AppUser>, IAppUserRepository
    {
        private readonly IDbConnection _dbConnection;
        public DpAppUserRepository(IDbConnection dbConnection) : base(dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public bool ChekUser(string userName, string password)
        {
            var user=  _dbConnection.QueryFirstOrDefault<AppUser>("select * from AppUsers where UserName=@userName and Password=@password",new { 
            userName=userName,
            password=password
            });
            return user != null;
        }

        public AppUser FindByName(string userName)
        {
            return _dbConnection.QueryFirstOrDefault<AppUser>("select * from AppUsers where UserName=@userName", new
            {
                userName = userName
            });
        }
    }
}
