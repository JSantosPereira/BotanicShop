using Microsoft.AspNetCore.Mvc;

namespace BotanicShop.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
