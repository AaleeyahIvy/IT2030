using Microsoft.AspNetCore.Mvc;
using PriceQuoteApp.Models;

namespace PriceQuoteApp
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.DiscountAmount = 0;
            ViewBag.Total = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(PriceQuotationModel price)
        {
            if (ModelState.IsValid)
            {
                ViewBag.DiscountAmount = price.CalDiscount((double)price.Subtotal, (double)price.DiscountPercent);
                ViewBag.Total = price.CalTotal((double)price.Subtotal, (double)price.DiscountAmount);
            }
            else
            {
                ViewBag.DiscountAmount = 0;
                ViewBag.Total = 0;
            }
            return View("Index", price);
        }

    }
}