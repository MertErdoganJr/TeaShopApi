using Microsoft.AspNetCore.Mvc;

namespace TeaShopApi.WebUI.ViewComponents
{
    public class _DefaultFooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
