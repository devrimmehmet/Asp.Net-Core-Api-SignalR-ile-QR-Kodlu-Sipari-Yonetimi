namespace DtoLayer.BookingDto
{
    public class ResultBookingDto
    {
        public int Booking_ID { get; set; }
        public string? Booking_Name { get; set; }
        public string? Booking_Phone { get; set; }
        public string? Booking_Mail { get; set; }
        public int Booking_Person_Count { get; set; }
        public DateTime Booking_Date { get; set; }
    }
}
