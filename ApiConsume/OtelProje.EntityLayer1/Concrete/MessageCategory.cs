﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelProje.EntityLayer1.Concrete
{
    public class MessageCategory
    {
        public int MessageCategoryID { get; set; }
        public string MessageCategoryName { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
