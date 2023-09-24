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
    public class IGuestManager : IGuestService
    {
        private readonly IGuestDal _guestDal;

        public IGuestManager(IGuestDal guestDal)
        {
            _guestDal = guestDal;
        }

        public void Delete(Guest t)
        {
            _guestDal.Delete(t);
        }

        public Guest GetByID(int id)
        {
            return _guestDal.GetByID(id);
        }

        public List<Guest> GetList()
        {
            return _guestDal.GetList();
        }

        public void Insert(Guest t)
        {
            _guestDal.Insert(t);
        }

        public void Update(Guest t)
        {
            _guestDal.Update(t);
        }
    }
}
