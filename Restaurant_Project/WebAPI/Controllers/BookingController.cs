using AutoMapper;
using BusinessLayer.Abstract;
using DtoLayer.BookingDto;
using DtoLayer.CategoryDto;
using EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService,IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _mapper.Map<List<ResultBookingDto>>(_bookingService.TGetListAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            _bookingService.TAdd(new Booking()
            {
                Booking_Mail = createBookingDto.Booking_Mail,
                Booking_Date = createBookingDto.Booking_Date,
                Booking_Name = createBookingDto.Booking_Name,
                Booking_Person_Count = createBookingDto.Booking_Person_Count,
                Booking_Phone = createBookingDto.Booking_Phone,
            });
            return Ok("Rezervasyon Yapıldı");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon Silindi");
        }
        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            _bookingService.TUpdate(new Booking()
            {
                Booking_ID = updateBookingDto.Booking_ID,
                Booking_Mail = updateBookingDto.Booking_Mail,
                Booking_Name = updateBookingDto.Booking_Name,
                Booking_Person_Count = updateBookingDto.Booking_Person_Count,
                Booking_Phone = updateBookingDto.Booking_Phone,
                Booking_Date = updateBookingDto.Booking_Date
            });
            return Ok("Rezervasyon Güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }
      
	}
}