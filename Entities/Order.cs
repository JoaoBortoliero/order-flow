using OrderFlow.Entities.Enums;

namespace OrderFlow.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItens { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItens.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItens.Remove(item);
        }

        public double total()
        {
            double sum = 0;
            foreach (OrderItem item in OrderItens)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
    }
}
