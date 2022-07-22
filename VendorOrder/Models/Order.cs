using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Description { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string description)
    {
      description = description;
      _instances.Add(this);
      Id - _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}