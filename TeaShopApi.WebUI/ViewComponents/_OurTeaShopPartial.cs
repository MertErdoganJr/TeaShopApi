using Microsoft.AspNetCore.Mvc;

namespace TeaShopApi.WebUI.ViewComponents
{
    public class _OurTeaShopPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
