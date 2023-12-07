using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.DataAccessLayer.Abstract;
using TeaShopApi.DtosLayer.TestimonialDtos;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonialService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            Testimonial testimonial = new Testimonial()
            {
                TestimonialImageUrl = createTestimonialDto.TestimonialImageUrl,
                TestimonialComment = createTestimonialDto.TestimonialComment,
                TestimonialName = createTestimonialDto.TestimonialName

            };
            _testimonialService.TInsert(testimonial);
            return Ok("Referans Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            _testimonialService.TDelete(value);
            return Ok("İçerik Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var values = _testimonialService.TGetById(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            Testimonial updateTestimonial = new Testimonial()
            {
                TestimonialID = updateTestimonialDto.TestimonialID,
                TestimonialName = updateTestimonialDto.TestimonialName,
                TestimonialImageUrl = updateTestimonialDto.TestimonialImageUrl,
                TestimonialComment = updateTestimonialDto.TestimonialComment
            };
            _testimonialService.TUpdate(updateTestimonial);
            return Ok("Güncelleme İşlemi Yapıldı");
        }
    }
}
