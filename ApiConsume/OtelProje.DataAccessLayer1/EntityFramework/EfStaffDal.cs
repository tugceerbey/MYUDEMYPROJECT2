using OtelProje.DataAccessLayer1.Abstract;
using OtelProje.DataAccessLayer1.Concrete;
using OtelProje.DataAccessLayer1.Repositories;
using OtelProje.EntityLayer1.Concrete;

namespace OtelProje.DataAccessLayer1.EntityFramework
{
    public class EfStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public EfStaffDal(Context context) : base(context)
        {
        }

        public int GetStaffCount()
        {
            using var context = new Context();
            var value = context.Staffs.Count();
            return value;
        }

        public List<Staff> Last4Staff()
        {
            using var context = new Context();
            var values = context.Staffs.OrderByDescending(x => x.StaffID).Take(4).ToList();
            return values;
        }
    }
}
