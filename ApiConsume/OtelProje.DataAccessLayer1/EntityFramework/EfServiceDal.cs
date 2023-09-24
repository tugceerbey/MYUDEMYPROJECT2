
using OtelProje.DataAccessLayer1.Repositories;
using OtelProje.DataAccessLayer1.Abstract;
using OtelProje.DataAccessLayer1.Concrete;
using OtelProje.EntityLayer1.Concrete;

namespace OtelProje.DataAccessLayer1.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>, IServicesDal
    {
        public EfServiceDal(Context context) : base(context)
        {
        }
    }
}
