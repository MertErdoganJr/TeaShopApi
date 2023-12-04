using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopApi.DtosLayer.ProductDto
{
    public class UpdateProductDto
    {
        public int ProductID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ProductImage { get; set; }
    }
}
