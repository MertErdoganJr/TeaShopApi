using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopApi.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ProductImage { get; set; }
    }
}
