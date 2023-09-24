using OtelProje.DataAccessLayer.Abstract;
using OtelProje.DataAccessLayer.Concrete;
using OtelProje.DataAccessLayer.Repositories;
using OtelProje.EntityLayer.Concrete;

namespace OtelProje.DataAccessLayer.EntityFramework
{
    public class EfSubscribeDal : IGenericRepository<Subscribe>, ISubscribeDal
    {
        public EfSubscribeDal(Context context) : base(context)
        {
        }
    }
}
