using System;

public class Class1
{
    public Class1()
    {


        public class OrderItem
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }


        public OrderItem(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }

    public class Order
    {

        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItem> Items { get; }


        public Order(int id, DateTime orderDate)
        {
            Id = id;
            OrderDate = orderDate;
            Items = new List<OrderItem>();
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
    }

}
}
