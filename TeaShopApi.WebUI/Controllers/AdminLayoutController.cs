using Microsoft.AspNetCore.Mvc;

namespace TeaShopApi.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
