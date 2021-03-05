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
    [TestMethod]
    public void SetOrderDetails_SetOrderDetails_String()
    {
      string orderDeets = "2 bread 2 pastry";
      Order newOrder = new Order(orderDeets);
      string updatedOrderDetails = "4 bread 4 wheat bread";
      newOrder.OrderDetails = updatedOrderDetails;
      string result = newOrder.OrderDetails;
      Assert.AreEqual(updatedOrderDetails, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }    
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string orderDetails1 = "2 loaves of bread";
      string orderDetails2 = "3 pastries";
      Order newOrder1 = new Order(orderDetails1);
      Order newOrder2 = new Order(orderDetails2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string orderDetails = "2 bread loaf one pastry";
      Order newOrder = new Order(orderDetails);
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }    
  }
}