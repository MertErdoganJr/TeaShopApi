using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.DataAccessLayer.Abstract;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.BusinessLayer.Concrete
{
    public class AboutUsManager : IAboutUsService
    {
        private readonly IAboutUsDal _aboutUsDal;

        public AboutUsManager(IAboutUsDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }

        public void TDelete(AboutUs entity)
        {
            _aboutUsDal.Delete(entity);
        }

        public AboutUs TGetById(int id)
        {
            return _aboutUsDal.GetById(id);
        }

        public List<AboutUs> TGetListAll()
        {
            return _aboutUsDal.GetListAll();
        }

        public void TInsert(AboutUs entity)
        {
            _aboutUsDal.Insert(entity);
        }

        public void TUpdate(AboutUs entity)
        {
            _aboutUsDal.Update(entity);
        }
    }
}
