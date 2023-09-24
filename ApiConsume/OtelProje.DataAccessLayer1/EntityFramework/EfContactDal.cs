using OtelProje.DataAccessLayer1.Abstract;
using OtelProje.DataAccessLayer1.Concrete;
using OtelProje.DataAccessLayer1.Repositories;
using OtelProje.EntityLayer1.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.DataAccessLayer1.EntityFramework
{
    public class EfContactDal:GenericRepository<Contact>,IContactDal
    {
        public EfContactDal(Context context) : base(context)
        {

        }

        public int GetContactCount()
        {
            var context = new Context();
            return context.Contacts.Count();
        }
    }
}
