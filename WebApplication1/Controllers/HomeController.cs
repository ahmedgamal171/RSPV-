using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using System.Linq;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour=DateTime.Now.Hour;
            int min=DateTime.Now.Minute;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
           return View("MyView");
        }
        [HttpGet]
        public ViewResult RSVPForm() { 
            return View();
        }
        [HttpPost]
        public ViewResult RSVPForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }
        public ViewResult ListResponses()
        {
            return View(Repository.GuestResponses.Where(r=>r.WillAttend==true));
        }
    }
}
