using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.DtosLayer.DrinkDtos;
using TeaShopApi.DtosLayer.QuestionDtos;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrinksController : ControllerBase
    {
        private readonly IDrinkService _drinkService;

        public DrinksController(IDrinkService drinkService)
        {
            _drinkService = drinkService;
        }

        [HttpGet]
        public IActionResult DrinkList()
        {
            var values = _drinkService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateDrink(CreateDrinkDto createDrinkDto)
        {
            Drink drink = new Drink()
            {
                DrinkImageUrl = createDrinkDto.DrinkImageUrl,
                DrinkName = createDrinkDto.DrinkName,
                DrinkPrice = createDrinkDto.DrinkPrice
            };
            _drinkService.TInsert(drink);
            return Ok("İçeceğiniz Eklendi");
        }

        [HttpDelete]
        public IActionResult DeleteDrink(int id)
        {
            var value = _drinkService.TGetById(id);
            _drinkService.TDelete(value);
            return Ok("İçerik Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetDrink(int id)
        {
            var values = _drinkService.TGetById(id);
            return Ok(values);
        }

        [HttpPut]
        public IActionResult UpdateDrink(UpdateDrinkDto updateDrinkDto)
        {
            Drink updatedDrink = new Drink()
            {
                DrinkID = updateDrinkDto.DrinkID,
                DrinkName = updateDrinkDto.DrinkName,
                DrinkImageUrl = updateDrinkDto.DrinkImageUrl,
                DrinkPrice= updateDrinkDto.DrinkPrice
            };
            _drinkService.TUpdate(updatedDrink);
            return Ok("Güncelleme İşlemi Yapıldı");
        }
    }
}
