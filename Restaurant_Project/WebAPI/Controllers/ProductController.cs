using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Abstract;
using DtoLayer.ProductDto;
using EntityLayer.Entities;
using DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                Product_Description = createProductDto.Product_Description,
                Product_Image_Url = createProductDto.Product_Image_Url,
                Product_Price = createProductDto.Product_Price,
                Product_Name = createProductDto.Product_Name,
                Product_Status = createProductDto.Product_Status,
              
              
            });
            return Ok("Ürün Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return Ok("Ürün Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                Product_ID = updateProductDto.Product_ID,
                Product_Description = updateProductDto.Product_Description,
                Product_Image_Url = updateProductDto.Product_Image_Url,
                Product_Price = updateProductDto.Product_Price,
                Product_Name = updateProductDto.Product_Name,
                Product_Status = updateProductDto.Product_Status,
            });
            return Ok("Ürün Bilgisi Güncellendi");
        }

        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var context = new RestaurantDbContext();
            var values =( context.Products?.Include(x => x.Category!).Select(y => new ResultProductWithCategoryDto
            {
                Product_ID = y.Product_ID,
                Product_Description = y.Product_Description,
                Product_Image_Url = y.Product_Image_Url,
                Product_Price = y.Product_Price,
                Product_Status = y.Product_Status,
                Category_Name = y.Category!.Category_Name,
            }))!;
            return Ok(values.ToList());
        }
     
	}
}
