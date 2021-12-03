using Microsoft.AspNetCore.Mvc;

namespace MotoGP.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult OrderTicket()
        {
            ViewBag.BannerNr = 3;

            return View();
        }
        public IActionResult ConfirmOrder()
        {
            ViewBag.BannerNr = 3;

            return View();
        }
        

    }
}
