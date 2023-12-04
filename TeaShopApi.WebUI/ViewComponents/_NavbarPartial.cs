using Microsoft.AspNetCore.Mvc;

namespace TeaShopApi.WebUI.ViewComponents
{
    public class _NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
