using OtelProje.DataAccessLayer1.Abstract;
using OtelProje.DataAccessLayer1.Repositories;
using OtelProje.DataAccessLayer1.Concrete;
using OtelProje.EntityLayer1.Concrete;

namespace OtelProje.DataAccessLayer1.EntityFramework
{
    public class EfRoomDal:GenericRepository<Room>,IRoomDal
    {
        public EfRoomDal(Context context): base(context)
        {

        }

        public int RoomCount()
        {
            var context = new Context();
            var value = context.Rooms.Count();
            return value;
        }
    }
}
