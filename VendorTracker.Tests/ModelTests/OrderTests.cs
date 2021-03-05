using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using VendorTracker.Models;

namespace VendorTracker.Tests
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
      Order newOrder = new Order("test purchase");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetOrderDetails_ReturnsOrderDetails_String()
    {
      string orderDetails = "Walk the dog.";
      Order newOrder = new Order(orderDetails);
      string result = newOrder.OrderDetails;
      Assert.AreEqual(orderDetails, result);
    }
  }
}