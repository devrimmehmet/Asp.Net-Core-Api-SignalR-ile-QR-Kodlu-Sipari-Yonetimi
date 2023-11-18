using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Abstract;
using DtoLayer.ContactDto;
using DtoLayer.DiscountDto;
using EntityLayer.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;
        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            _discountService.TAdd(new Discount()
            {
                Discount_Amount = createDiscountDto.Discount_Amount,
                Discount_Description = createDiscountDto.Discount_Amount,
                Discount_Image_Url = createDiscountDto.Discount_Amount,
                Discount_Title = createDiscountDto.Discount_Amount,
              
            });
            return Ok("İndirim Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            _discountService.TDelete(value);
            return Ok("İndirim Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            _discountService.TUpdate(new Discount()
            {
                Discount_ID = updateDiscountDto.Discount_ID,
                Discount_Amount = updateDiscountDto.Discount_Amount,
                Discount_Description = updateDiscountDto.Discount_Amount,
                Discount_Image_Url = updateDiscountDto.Discount_Amount,
                Discount_Title = updateDiscountDto.Discount_Amount,
            });
            return Ok("İndirim Bilgisi Güncellendi");
        }
     
	}
}
