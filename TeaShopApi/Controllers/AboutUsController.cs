using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.DtosLayer.AboutUsDto;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsService _aboutUsService;

        public AboutUsController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        [HttpGet]
        public IActionResult AboutUsList()
        {
            var values = _aboutUsService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateAboutUs(CreateAboutUsDto createAboutUsDto)
        {
            AboutUs aboutUs = new AboutUs()
            {
                Title = createAboutUsDto.Title,
                Description = createAboutUsDto.Description
            };
            _aboutUsService.TInsert(aboutUs);
            return Ok("Hakkımda Kısmı Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteAboutUs(int id)
        {
            var value = _aboutUsService.TGetById(id);
            _aboutUsService.TDelete(value);
            return Ok("İçerik Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetAboutUs(int id)
        {
            var value = _aboutUsService.TGetById(id);
            return Ok(value);
        }
    }
}
