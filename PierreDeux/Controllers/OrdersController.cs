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
    [HttpGet("/vendors/{vendorId}/orders/{id}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}