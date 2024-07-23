
using composition3_csharp.Entities;
using composition3_csharp.Entities.Enums;
using System.Globalization;
namespace composition3_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data");
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Email: ");
            var email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY) ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter the order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items in this order? ");
            int quantityItems = int.Parse(Console.ReadLine());

            Order order = new Order(status, client);

            List<OrderItem> orderItems = new List<OrderItem>();

            for (int i = 1; i <= quantityItems; i++)
            {
                Console.WriteLine($"Enter the #{i}");
                Console.Write("Product Name: ");
                var productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                order.AddOrder(new OrderItem(quantity, new Product(productName, price)));

            }

            Console.WriteLine(order.ToString());
        }
    }


}