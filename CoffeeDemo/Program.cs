using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopLib;

namespace CoffeeDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuItem pasta = new MenuItem("pasta", "pasta description", 10.4M);
            MenuItem pizza = new MenuItem("pizza", "pizza description", 12.4M);
            MenuItem rice = new MenuItem("rice", "rice description", 6.2M);
            MenuItem chicken = new MenuItem("chicken", "chicken description", 8.3M);
             

            Customer customer1 = new Customer("Young", "46 Lehar", "Toronto", "Ontario", "4167315950");
            Customer customer2 = new Customer("Ben", "46 Lehar", "Toronto", "Ontario", "4167315950");

            Order order1 = customer1.CreateOrder(OrderTypes.phoneOrder);
            Order order2 = customer2.CreateOrder(OrderTypes.RestaurantOrder);

            order1.AddOrderItem(pizza);
            order1.AddOrderItem(rice);
            order1.AddOrderItem(chicken);

            order2.AddOrderItem(chicken);
            order2.AddOrderItem(pasta);

            OrderItem orderItemList1 = new OrderItem(order1.OrderItems);
            OrderItem orderItemList2 = new OrderItem(order2.OrderItems);

            Console.WriteLine("----------menu------------");
            Console.WriteLine(pasta.GetInfo());
            Console.WriteLine(pizza.GetInfo());
            Console.WriteLine(rice.GetInfo());
            Console.WriteLine(chicken.GetInfo());

            Console.WriteLine("------customer-----------");
            Console.WriteLine(customer1.GetInfo());
            Console.WriteLine(customer2.GetInfo());

            Console.WriteLine("--------Order-----");
            Console.WriteLine(order1.GetInfo());
            Console.WriteLine(order2.GetInfo());

            Console.WriteLine("--------Order Item Lists -----");

            Console.WriteLine(orderItemList1.GetInfo());
            Console.WriteLine(orderItemList2.GetInfo());


            Console.WriteLine("-----order is deliverd------");
            order1.Delivered();
            order2.Delivered();
            Console.WriteLine(order1.GetInfo());
            Console.WriteLine(order2.GetInfo());
        }
    }
}
