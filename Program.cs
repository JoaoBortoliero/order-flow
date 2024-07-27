using OrderFlow.Entities;
using OrderFlow.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter cliente data: ");

Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Email: ");
string email = Console.ReadLine();

Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Enter order data: ");

Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());


Client client1 = new Client(name, email, birthDate);
DateTime moment = DateTime.Now;
Order order1 = new Order(moment, status, client1);

Console.Write("How many items to this order? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter #{i + 1} itme data: ");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int productQuantity = int.Parse(Console.ReadLine());
    Product produto1 = new Product(productName, productPrice);
    OrderItem orderItem1 = new OrderItem(productQuantity, productPrice, produto1);
    order1.AddItem(orderItem1);
}

Console.WriteLine("\nORDER SUMMARY:");
Console.WriteLine("Order moment: " + order1.Moment);
Console.WriteLine("Order status: " + order1.Status);
Console.WriteLine("Client: " + client1);
Console.WriteLine("Order items: ");
foreach (OrderItem item in order1.OrderItens)
{
    Console.WriteLine(item);
}
Console.WriteLine("Total price: $" + order1.total().ToString("F2", CultureInfo.InvariantCulture));

