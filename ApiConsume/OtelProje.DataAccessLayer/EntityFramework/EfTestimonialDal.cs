using OtelProje.DataAccessLayer.Abstract;
using OtelProje.DataAccessLayer.Concrete;
using OtelProje.DataAccessLayer.Repositories;
using OtelProje.EntityLayer.Concrete;

namespace OtelProje.DataAccessLayer.EntityFramework
{
    public class EfTestimonialDal : IGenericRepository<Testimonial>, ITestimonialDal
    {
        public EfTestimonialDal(Context context) : base(context)
        {
        }
    }
}
