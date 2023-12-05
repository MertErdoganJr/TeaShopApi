using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopApi.BusinessLayer.Abstract
{
    public interface IStatisticsService
    {
        int TDrinkCount();
        decimal TDrinkAVGPrice();
        string TLastDrinkName();
        string TMaxPriceDrink();
    }
}
