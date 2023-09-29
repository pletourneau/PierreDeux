using System.Collections.Generic;
using System;

namespace PierreDeux.Models
{
  public class Order
  {
   public string Description { get; set; }
   public string Title { get; set; }
   public int Id { get; }

   public float Price { get; set; }
   public DateTime Date { get; set; }
   private static List<Order> _instances = new List<Order> {};

   public Order(string Description, string title, float Price)
   {
    

   }
   public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
