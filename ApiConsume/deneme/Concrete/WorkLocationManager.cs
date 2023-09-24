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
    public class WorkLocationManager : IWorkLocationService
    {
        private readonly IWorkLocationDal _workLocationDal;

        public WorkLocationManager(IWorkLocationDal workLocationDal)
        {
            _workLocationDal = workLocationDal;
        }

        public void Delete(WorkLocation t)
        {
            _workLocationDal.Delete(t);
        }

        public WorkLocation GetByID(int id)
        {
            return _workLocationDal.GetByID(id);
        }

        public List<WorkLocation> GetList()
        {
            return _workLocationDal.GetList();
        }

        public void Insert(WorkLocation t)
        {
            _workLocationDal.Insert(t);
        }

        public void Update(WorkLocation t)
        {
            _workLocationDal.Update(t);
        }
    }
}
