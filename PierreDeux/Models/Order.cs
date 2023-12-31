using System.Collections.Generic;
using System;

namespace PierreDeux.Models
{
  public class Order
  {
   public string Description { get; set; }
   public string Title { get; set; }
   public int Id { get; set; }

   public float Price { get; set; }
   public string Date { get; set; }
   private static List<Order> _instances = new List<Order> {};

   public Order(string orderDescription, string orderTitle, float orderPrice, string orderDate)
   {
    Description = orderDescription;
    Title = orderTitle;
    Price = orderPrice;
    Date = orderDate;
    _instances.Add(this);
    Id = _instances.Count;
   }
   public static void ClearAll()
    {
      _instances.Clear();
    }
   public static List<Order> GetAll()
    {
      return _instances;
    }
    public static Order Find(int searchId)
    {
      return _instances[searchId -1];
    }
  }
}
