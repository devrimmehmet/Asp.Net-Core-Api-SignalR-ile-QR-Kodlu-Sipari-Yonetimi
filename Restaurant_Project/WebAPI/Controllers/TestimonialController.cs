using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Abstract;
using DtoLayer.TestimonialDto;
using EntityLayer.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;
        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
                Testimonial_Comment = createTestimonialDto.Testimonial_Comment,
                Testimonial_Image_Url = createTestimonialDto.Testimonial_Image_Url,
                Testimonial_Title = createTestimonialDto.Testimonial_Title,
                Testimonial_Name = createTestimonialDto.Testimonial_Name,
                Testimonial_Status = createTestimonialDto.Testimonial_Status,
              
              
            });
            return Ok("Yorum Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            _testimonialService.TDelete(value);
            return Ok("Yorum Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
                Testimonial_ID = updateTestimonialDto.Testimonial_ID,
                Testimonial_Comment = updateTestimonialDto.Testimonial_Comment,
                Testimonial_Image_Url = updateTestimonialDto.Testimonial_Image_Url,
                Testimonial_Title = updateTestimonialDto.Testimonial_Title,
                Testimonial_Name = updateTestimonialDto.Testimonial_Name,
                Testimonial_Status = updateTestimonialDto.Testimonial_Status,
            });
            return Ok("Müşteri Yorumu Güncellendi");
        }
     
	}
}
