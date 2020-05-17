using Enum.Entities;
using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 743235,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered
            };

            Console.WriteLine(order);

            //enum to string
            //Console.WriteLine(OrderStatus.PendingPayment.ToString());

        }
    }
}
