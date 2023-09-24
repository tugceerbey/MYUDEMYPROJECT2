using OtelProje.DataAccessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;

namespace OtelProje.DataAccessLayer1.Abstract
{
    public interface IRoomDal:IGenericDal<Room>
    {
        int RoomCount();
    }
}
