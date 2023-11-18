using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Abstract;
using DtoLayer.FeatureDto;
using EntityLayer.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;
        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult FeatureList()
        {
            var value = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            _featureService.TAdd(new Feature()
            {
                Feature_Description_1 = createFeatureDto.Feature_Description_1,
                Feature_Description_2 = createFeatureDto.Feature_Description_2,
                Feature_Description_3 = createFeatureDto.Feature_Description_3,
                Feature_Title_1 = createFeatureDto.Feature_Title_1,
                Feature_Title_2 = createFeatureDto.Feature_Title_2,
                Feature_Title_3 = createFeatureDto.Feature_Title_3
              
              
            });
            return Ok("Feature Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFeature(int id)
        {
            var value = _featureService.TGetById(id);
            _featureService.TDelete(value);
            return Ok("Feature Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetFeature(int id)
        {
            var value = _featureService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            _featureService.TUpdate(new Feature()
            {
                Feature_ID = updateFeatureDto.Feature_ID,
                Feature_Description_1 = updateFeatureDto.Feature_Description_1,
                Feature_Description_2 = updateFeatureDto.Feature_Description_2,
                Feature_Description_3 = updateFeatureDto.Feature_Description_3,
                Feature_Title_1 = updateFeatureDto.Feature_Title_1,
                Feature_Title_2 = updateFeatureDto.Feature_Title_2,
                Feature_Title_3 = updateFeatureDto.Feature_Title_3
            });
            return Ok("Feature Bilgisi Güncellendi");
        }
     
	}
}
