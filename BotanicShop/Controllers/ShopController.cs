﻿using Microsoft.AspNetCore.Mvc;

namespace BotanicShop.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult ProductShop()
        {
            return View();
        }
    }
}
