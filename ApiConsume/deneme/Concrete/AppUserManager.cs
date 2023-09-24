using Otelproje.BusinessLayer1.Abstract;
using OtelProje.DataAccessLayer1.Abstract;
using OtelProje.DataAccessLayer1.EntityFramework;
using OtelProje.EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otelproje.BusinessLayer1.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;
        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }


        public void Delete(AppUser t)
        {
            throw new NotImplementedException();
        }

        public AppUser GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetList()
        {
            return _appUserDal.GetList();
        }

        public void Insert(AppUser t)
        {
            throw new NotImplementedException();
        }

        public int TAppUserCount()
        {
            return _appUserDal.AppUserCount();
        }

        public void Update(AppUser t)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> UserListWithWorkLocation()
        {
            return _appUserDal.UserListWithWorkLocation();
        }

        public List<AppUser> UserListWithWorkLocations()
        {
            throw new NotImplementedException();
        }

       
    }
}

