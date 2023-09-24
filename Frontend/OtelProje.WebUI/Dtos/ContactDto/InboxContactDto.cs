﻿namespace OtelProje.WebUI.Dtos.ContactDto
{
    public class InboxContactDto
    {
        public string ContactID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
    }
}
