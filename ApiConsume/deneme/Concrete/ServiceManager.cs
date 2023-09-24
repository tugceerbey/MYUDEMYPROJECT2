using Otelproje.BusinessLayer1.Abstract;
using OtelProje.DataAccessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;

namespace Otelproje.BusinessLayer1.Concrete
{
    public class ServiceManager : IServiceService
    {
        private readonly IServicesDal _servicesDal;

        public ServiceManager(IServicesDal servicesDal)
        {
            _servicesDal = servicesDal;
        }

        public void Delete(Service t)
        {
            _servicesDal.Delete(t);
        }

        public Service GetByID(int id)
        {
            return _servicesDal.GetByID(id);
        }

        public List<Service> GetList()
        {
            return _servicesDal.GetList();
        }

        public void Insert(Service t)
        {
            _servicesDal.Insert(t);
        }

        public void Update(Service t)
        {
            _servicesDal.Update(t);
        }
    }
}
