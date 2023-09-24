using OtelProje.DataAccessLayer.Abstract;
using OtelProje.DataAccessLayer.Concrete;
using OtelProje.DataAccessLayer.Repositories;
using OtelProje.EntityLayer.Concrete;

namespace OtelProje.DataAccessLayer.EntityFramework
{
    public class EfStaffDal : IGenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
        }
    }
}
