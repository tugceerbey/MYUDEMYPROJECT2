using OtelProje.EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otelproje.BusinessLayer1.Abstract
{
    public interface IAppUserService:IGenericService<AppUser>
    {
        List<AppUser> UserListWithWorkLocation();
        List<AppUser> UserListWithWorkLocations();
        int TAppUserCount();
    }
}
