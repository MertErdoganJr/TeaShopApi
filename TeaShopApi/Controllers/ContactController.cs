using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.DtosLayer.ContactDtos;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _contactService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            Contact contact = new Contact()
            {
                Name = createContactDto.Name,
                Email = createContactDto.Email,
                Subject = createContactDto.Subject,
                Message = createContactDto.Message,
            };
            _contactService.TInsert(contact);
            return Ok("Bilgiler Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TDelete(value);
            return Ok("Mesaj silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateProdcutDto)
        {
            Contact contact = new Contact()
            {
                ContactID = updateProdcutDto.ContactID,
                Name = updateProdcutDto.Name,
                Email = updateProdcutDto.Email,
                Subject = updateProdcutDto.Subject,
                Message = updateProdcutDto.Message
            };
            _contactService.TUpdate(contact);
            return Ok("Mesaj Güncellendi");
        }
    }
}
