using AutoMapper;
using DtoLayer.AboutDto;
using EntityLayer.Entities;

namespace WebAPI.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping() 
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();//ReverseMap karşılıklı işlevsellik kazandırmak için yani tam tersi durum içinde işe yarıyor bu mapleme.
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
        }
    }
}
