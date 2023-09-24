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
    public class SendMessageManager : ISendMessageService
    {
        private readonly ISendMessageDal _sendMessageDal;
        public SendMessageManager(ISendMessageDal sendMessageDal)
        {
            _sendMessageDal = sendMessageDal;
        }

        public void Delete(SendMessage t)
        {
            _sendMessageDal.Delete(t);
        }

        public SendMessage GetByID(int id)
        {
            return _sendMessageDal.GetByID(id);
        }

        public List<SendMessage> GetList()
        {
           return _sendMessageDal.GetList();
        }

        public void Insert(SendMessage t)
        {
            _sendMessageDal.Insert(t);  
        }

        public int TGetSendMessageCount()
        {
            return _sendMessageDal.GetSendMessageCount();
        }

        public void Update(SendMessage t)
        {
            _sendMessageDal.Update(t);
        }
    }
}
