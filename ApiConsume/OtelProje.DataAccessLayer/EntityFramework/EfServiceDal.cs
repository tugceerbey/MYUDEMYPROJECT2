using OtelProje.DataAccessLayer.Abstract;
using OtelProje.DataAccessLayer.Concrete;
using OtelProje.DataAccessLayer.Repositories;
using OtelProje.EntityLayer.Concrete;

namespace OtelProje.DataAccessLayer.EntityFramework
{
    public class EfServiceDal : IGenericRepository<Service>, IServicesDal
    {
        public EfServiceDal(Context context) : base(context)
        {
        }
    }
}
