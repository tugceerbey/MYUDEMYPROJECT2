using Otelproje.BusinessLayer1.Abstract;
using OtelProje.DataAccessLayer1.Abstract;
using OtelProje.EntityLayer1.Concrete;

namespace Otelproje.BusinessLayer1.Concrete
{
    public class ISubscribeManager : ISubscribeService
    {
        private readonly ISubscribeDal _subscribeDal;

        public ISubscribeManager(ISubscribeDal subscribeDal)
        {
            _subscribeDal = subscribeDal;
        }

        public void Delete(Subscribe t)
        {
            _subscribeDal.Delete(t);
        }

        public Subscribe GetByID(int id)
        {
            return _subscribeDal.GetByID(id);
        }

        public List<Subscribe> GetList()
        {
            return _subscribeDal.GetList();
        }

        public void Insert(Subscribe t)
        {
            _subscribeDal.Insert(t);
        }

        public void Update(Subscribe t)
        {
            _subscribeDal.Update(t);
        }
    }
}
