using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Customer
    {
        private uint idNumber;
        private string name;
        public Address MyAddress;
        private string telephoneNumber;
        private Order[] orders;

        private const uint SIZE = 50;
        private uint numberOfOrders = 0;
        private static uint numberOfId;

        public uint IdNumber
        {
            get { return idNumber; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string TelephoneNumber
        {
            get { return telephoneNumber; }
            set
            {
                if (value.Length == 10)
                {
                    telephoneNumber = value;
                }
            }
        }
        public Order[] Orders
        {
            get { return orders; }
            private set { orders = value; }
        }

        static Customer()
        {
            numberOfId = 0;
        }

        public Customer(string name, string street, string city, string province, string phoneNum)
        {
            idNumber = numberOfId++;

            Orders = new Order[SIZE];

            Name = name;
            MyAddress.Street = street;
            MyAddress.City = city;
            MyAddress.Province = province;
            TelephoneNumber = phoneNum;
        }

        public Order CreateOrder(OrderTypes typeOfOrder)
        {
            Order newOrder = new Order(this, DateTime.Now);
            if (numberOfOrders < SIZE)
            {
                newOrder.OrderType = typeOfOrder;
                Orders[numberOfOrders++] = newOrder;
            }
            return newOrder;
        }

        public string GetInfo()
        {
            string result = "";
            result += $"customer id:{IdNumber}, name:{Name} address:{MyAddress.GetInfo()} phone:{TelephoneNumber}\n\n";

            return result;
        }

    }
}
