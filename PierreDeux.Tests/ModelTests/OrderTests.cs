using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreDeux.Models;
using System;

namespace PierreDeux.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "title", 13.31f, "09/29/23");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "one dozen baguettes";
      string date = "09/29/23";
      string title = "weekly order";
      float price = 13.31f;

      //Act
      Order newOrder = new Order(description, title, price, date);
      string result = newOrder.Description;

      //Assert
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      //Arrange
      string description = "one dozen baguettes";
      string date = "09/29/23";
      string title = "weekly order";
      float price = 13.31f;

      //Act
      Order newOrder = new Order(description, title, price, date);
      string result = newOrder.Date;

      //Assert
      Assert.AreEqual(date, result);
    }
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string description = "one dozen baguettes";
      string date = "09/29/23";
      string title = "weekly order";
      float price = 13.31f;

      //Act
      Order newOrder = new Order(description, title, price, date);
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    }
  }
}
