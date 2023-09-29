using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierreDeux.Models;
using System;

namespace PierreDeux.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
    }
  }
}
