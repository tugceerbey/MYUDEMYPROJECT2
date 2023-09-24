using Otelproje.BusinessLayer1.Abstract;
using OtelProje.DataAccessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;

namespace Otelproje.BusinessLayer1.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Delete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public Testimonial GetByID(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public List<Testimonial> GetList()
        {
            return _testimonialDal.GetList();
        }

        public void Insert(Testimonial t)
        {
            _testimonialDal.Insert(t);
        }

        public void Update(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
