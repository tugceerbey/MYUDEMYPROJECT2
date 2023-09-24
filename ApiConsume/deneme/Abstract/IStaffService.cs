using Otelproje.BusinessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;

namespace Otelproje.BusinessLayer1.Abstract
{
    public interface IStaffService:IGenericService<Staff>
    {
        int TGetStaffCount();
        List<Staff> TLast4Staff();
    }
}
