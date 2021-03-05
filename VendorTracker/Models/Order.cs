using System.Collections.Generic;
namespace VendorTracker.Models
{
  public class Order
  {
    public string OrderDetails { get; set;}
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};
    public Order(string orderDetails)
    {
      OrderDetails = orderDetails;
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
      return _instances[searchId-1];
    }
  }
}