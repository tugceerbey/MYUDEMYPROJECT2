using OtelProje.DataAccessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;

namespace OtelProje.DataAccessLayer1.Abstract
{
    public interface IStaffDal:IGenericDal<Staff>
    {
        int GetStaffCount();
        List<Staff> Last4Staff();
    }
}
