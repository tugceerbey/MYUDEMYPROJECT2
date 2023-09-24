using System.Collections.Generic;
namespace Otelproje.BusinessLayer1.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetByID(int id);
    }
}
