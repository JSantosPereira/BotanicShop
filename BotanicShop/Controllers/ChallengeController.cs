using Microsoft.AspNetCore.Mvc;

namespace BotanicShop.Controllers
{
    public class ChallengeController : Controller
    {
        public IActionResult DailyChallenge()
        {
            return View();
        }
        public IActionResult AddChallenge()
        {
            return View();
        }
    }
}
