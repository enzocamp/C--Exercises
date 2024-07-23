using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using composition3_csharp.Entities.Enums;

namespace composition3_csharp.Entities
{
    internal class Order
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(OrderStatus status, Client client)
        {
            Status = status;
            Client = client;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order Moment: ");
            sb.AppendLine(Date.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("OrderStatus: ");
            sb.AppendLine(Status.ToString());
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order Items");
            foreach(OrderItem item in Items) {
                sb.Append(item.Product.Name + ",  $");
                sb.Append(item.Price.ToString(CultureInfo.InvariantCulture));
                sb.Append("Quantity: " + item.Quantity.ToString() + ", ");
                sb.AppendLine("Subtotal: $" + item.SubTotal().ToString(CultureInfo.InvariantCulture));
            }
            sb.AppendLine("Total Price: $" + Total());

            return sb.ToString();

        }

        public void AddOrder(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveOrder(OrderItem item) 
        {
            Items.Remove(item); 
        }

        public double Total() 
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
    }
}
