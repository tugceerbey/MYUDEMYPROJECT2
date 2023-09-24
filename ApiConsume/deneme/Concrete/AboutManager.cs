using Otelproje.BusinessLayer1.Abstract;
using OtelProje.DataAccessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otelproje.BusinessLayer1.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Delete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About GetByID(int id)
        {
           return _aboutDal.GetByID(id);
        }

        public List<About> GetList()
        {
            return _aboutDal.GetList();
        }

        public void Insert(About t)
        {
            _aboutDal.Insert(t);
        }

        public void Update(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
