using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopApi.DtosLayer.DrinkDtos
{
    public class UpdateDrinkDto
    {
        public string DrinkName { get; set; }
        public decimal DrinkPrice { get; set; }
        public string DrinkImageUrl { get; set; }
    }
}
