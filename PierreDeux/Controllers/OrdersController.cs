using Microsoft.AspNetCore.Mvc;
using PierreDeux.Models;
using System.Collections.Generic;

namespace PierreDeux.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }

    
  }
}