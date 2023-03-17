using CW14_1.DAL;
using CW14_1.Models;
using CW14_1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CW14_1.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CompleteOrder(string? input)
        {
            ViewBag.Input = input;
            var random = new Random();
            ViewBag.RandomNumber = random.Next(1000,9999);
            return View();
        }
        [HttpPost]
        public IActionResult? CompleteOrder(CompleteOrderViewModel model,int generalcapchaCode)
        {
            if (Repository.CheckCapcha(model, generalcapchaCode))
            {
                
                Repository.Informations.Add(new DataGet()
                {
                    CartNumber = model.CartNumber,
                    Price = model.Price
                });
                return View("Index");
            }
           

            return CompleteOrder("کد صحیح نیست ");
        }
        
        public IActionResult ShowRequestDetails()
        {
            ViewBag.ip = HttpContext.Connection.RemoteIpAddress;
            ViewBag.method= HttpContext.Request.Method;

            return View();
        }
       public bool CheckCardNumber (string? CartNumber)
        {
            if(CartNumber != null)
            {
                var cheker = CartNumber.Substring(0, 4);
                if (cheker == "6037")
                {
                    return true;
                }
            }
         
             return false;
            
        }
    }
}
