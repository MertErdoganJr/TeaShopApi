using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.DataAccessLayer.Abstract;
using TeaShopApi.DataAccessLayer.Concrete;
using TeaShopApi.DataAccessLayer.Context;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.DataAccessLayer.EntityFramework
{
    public class EfAboutUsDal : GenericRepository<AboutUs>, IAboutUsDal
    {
        public EfAboutUsDal(TeaContext context) : base(context)
        {
        }
    }
}
