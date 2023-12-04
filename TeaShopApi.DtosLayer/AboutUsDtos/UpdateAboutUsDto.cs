using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaShopApi.DtosLayer.AboutUsDto
{
    public class UpdateAboutUsDto
    {
        public int AboutUsID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}
