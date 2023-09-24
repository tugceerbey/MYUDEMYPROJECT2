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
    public class EfAboutDal:GenericRepository<About>,IAboutDal
    {
        public EfAboutDal(Context context) : base(context)
        {

        }
    }
}
