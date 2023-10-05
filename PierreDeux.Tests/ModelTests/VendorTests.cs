using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreDeux.Models;
using System;

namespace PierreDeux.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "safeway");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "testVendor";
      string description = "Safeway";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      //Arrange
      string name = "testVendor";
      string description = "Safeway";
      Vendor newVendor = new Vendor(name, description);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string name = "testVendor";
      string description = "Safeway";
      Vendor newVendor = new Vendor(name, description);

      //Act
      string result = newVendor.Description;

      //Assert
      Assert.AreEqual(description, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name1 = "testVendor1";
      string description1 = "Safeway";
      string name2 = "testVendor2";
      string description2 = "Thriftway";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name01 = "TacoBell";
      string name02 = "Safeway";
      string desc01 = "tacos";
      string desc02 = "Evil corporation";
      Vendor newVendor1 = new Vendor(name01, desc01);
      Vendor newVendor2 = new Vendor(name02, desc02);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor2, result);
    }
    
    [TestMethod]
    public void AddOrder_ShouldAddOrderToList()
    {
      // Arrange
      Order newOrder = new Order("stuff", "title", 13f, "13/13/13");
      Vendor newVendor = new Vendor("Safeway", "monopoly");

      // Act
      newVendor.AddOrder(newOrder);

      // Assert
      CollectionAssert.Contains(newVendor.Orders, newOrder);
      
    }
  }
}
