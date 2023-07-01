using Microsoft.AspNetCore.Mvc;

namespace BotanicShop.Controllers
{
    public class ChallengeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
