using OtelProje.DataAccessLayer1.Abstract;
using OtelProje.DataAccessLayer1.Concrete;
using OtelProje.DataAccessLayer1.Repositories;
using OtelProje.EntityLayer1.Concrete;

namespace OtelProje.DataAccessLayer1.EntityFramework
{
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
        public EfTestimonialDal(Context context) : base(context)
        {
        }
    }
}
