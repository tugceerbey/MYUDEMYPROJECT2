namespace OtelProje.WebUI.Dtos.BookingDto
{
    public class ApprovedReservationDto

    {
        public int BookingID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime CheckOut { get; set; }
        public String AdultCount { get; set; }
        public String ChildCount { get; set; }
        public String RoomCount { get; set; }
        public String SpecialRequest { get; set; }
        public String Description { get; set; }
        public String Status { get; set; }
    }
}
