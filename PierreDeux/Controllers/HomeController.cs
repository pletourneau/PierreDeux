using Microsoft.AspNetCore.Mvc;

namespace PierreDeux.Controllers
{
    public class HomeController : Controller
    {
     [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}