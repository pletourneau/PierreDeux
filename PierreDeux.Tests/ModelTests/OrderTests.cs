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
    [TestMethod]
    public void GetPrice_ReturnsPrice_Float()
    {
      //Arrange
      string description = "one dozen baguettes";
      string date = "09/29/23";
      string title = "weekly order";
      float price = 13.31f;

      //Act
      Order newOrder = new Order(description, title, price, date);
      float result = newOrder.Price;

      //Assert
      Assert.AreEqual(price, result);
    }
    [TestMethod]
    public void GetId_ReturnsId_Id()
    {
      //Arrange
      string description = "one dozen baguettes";
      string date = "09/29/23";
      string title = "weekly order";
      float price = 13.31f;

      //Act
      Order newOrder = new Order(description, title, price, date);
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(newOrder.Id, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
    //Arrange
    string title1 = "additional order";
    string description1 = "one birthday cake";
    string orderDate1 = "09/22/23";
    float price1 = 1.01f;
    string title2 = "Weekly order";
    string description2 = "one dozen baguettes"; 
    string orderDate2 = "09/20/23" ; 
    float price2 = 13.31f;
    Order newOrder1 = new Order(description1, title1, price1, orderDate1);
    Order newOrder2 = new Order(description2, title2, price2, orderDate2);
    List<Order> newList = new List<Order> { newOrder1, newOrder2 };

    //Act
    List<Order> result = Order.GetAll();

    //Assert
    CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string desc1 = "Tacos";
      string title1 = "weekly order";
      float price1 = 13f;
      string date1 = "13/13/13";
      string desc2 = "notTacos";
      string title2 = "monthly order";
      float price2 = 15f;
      string date2 = "18/18/18";
      Order newOrder1 = new Order(desc1, title1, price1, date1);
      Order newOrder2 = new Order(desc2, title2, price2, date2);

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }
  }
}
