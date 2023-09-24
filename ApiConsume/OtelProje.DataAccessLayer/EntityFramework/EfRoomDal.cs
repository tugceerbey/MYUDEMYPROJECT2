using OtelProje.DataAccessLayer.Abstract;
using OtelProje.DataAccessLayer.Concrete;
using OtelProje.DataAccessLayer.Repositories;
using OtelProje.EntityLayer.Concrete;

namespace OtelProje.DataAccessLayer.EntityFramework
{
    public class EfRoomDal:IGenericRepository<Room>,IRoomDal
    {
        public EfRoomDal(Context context): base(context)
        {

        }
    }
}
