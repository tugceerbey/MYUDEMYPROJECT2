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
    public class MessageCategoryManager : IMessageCategoryService
    {
        private readonly IMessageCategoryDal _messageCategoryDal;

        public MessageCategoryManager(IMessageCategoryDal messageCategoryDal)
        {
            _messageCategoryDal = messageCategoryDal;
        }

        public void Delete(MessageCategory t)
        {
            throw new NotImplementedException();
        }

        public MessageCategory GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<MessageCategory> GetList()
        {
            return _messageCategoryDal.GetList();
        }

        public void Insert(MessageCategory t)
        {
            throw new NotImplementedException();
        }

        public void Update(MessageCategory t)
        {
            throw new NotImplementedException();
        }
    }
}
