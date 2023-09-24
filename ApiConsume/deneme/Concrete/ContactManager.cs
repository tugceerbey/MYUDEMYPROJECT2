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
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Delete(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact GetByID(int id)
        {
            return _contactDal.GetByID(id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.GetList();
        }
        public int TGetContactCount()
        {
            return _contactDal.GetContactCount();
        }


        public void Insert(Contact t)
        {
         _contactDal.Insert(t);
        }

        public void Update(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
