using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Abstract;
using DtoLayer.CategoryDto;
using DtoLayer.ContactDto;
using EntityLayer.Entities;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact()
            {
                Contact_Description = createContactDto.Contact_Description,
                Contact_Location = createContactDto.Contact_Location,
                Contact_Mail = createContactDto.Contact_Mail,
                Contact_Phone = createContactDto.Contact_Phone,
          
            });
            return Ok("İletişim Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TDelete(value);
            return Ok("İletişim Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _contactService.TUpdate(new Contact()
            {
                Contact_ID = updateContactDto.Contact_ID,
                Contact_Description = updateContactDto.Contact_Description,
                Contact_Location = updateContactDto.Contact_Location,
                Contact_Mail = updateContactDto.Contact_Mail,
                Contact_Phone = updateContactDto.Contact_Phone,
            });
            return Ok("İletişim Bilgisi Güncellendi");
        }
    }
}
