using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class Order
    {

        private uint id;
        private Customer customer;
        private DateTime orderTime;
        private DateTime deliveryTime;
        private Address deliveryAddress;
        private decimal cost;
        private OrderTypes orderType;
        private MenuItem[] orderItems;
        private bool isDeliverd;

        private uint numberOfItems = 0;
        private const int _maxItems = 50;
        private static uint numberOfOrders;

        public uint Id
        {
            get { return id; }
        }
        public Customer Customer
        {
            get { return customer; }
           private set { customer = value; }
        }
        public DateTime OrderTime
        {
            get { return orderTime; }
        }
        public DateTime DeliveryTime
        {
            get { return deliveryTime; }
        }
        public Address DeliveryAddress
        {
            get { return deliveryAddress; }
           private set { deliveryAddress = value; }
        }

        public MenuItem[] OrderItems
        {
            get { return orderItems; }
            private set { orderItems = value; }
        }
        public decimal Cost
        {
            get { return cost; }
           private set { cost = value; }
        }
        public OrderTypes OrderType
        {
            get { return orderType; }
            set { orderType = value; }
        }
        
        public bool Deliverd
        {
            get { return isDeliverd; }
            private set
            {
                isDeliverd = value;
                if (isDeliverd)
                {
                    deliver();
                }
            }
        }
        static Order()
        {
            numberOfOrders = 0;
        }
        public Order(Customer customer, DateTime orderTime)
        { 
            numberOfOrders++;
            id = numberOfOrders;         
            DeliveryAddress = customer.MyAddress;
            this.orderTime = orderTime;
            Customer = customer;
            OrderItems = new MenuItem[_maxItems];
        }

        public void AddOrderItem(MenuItem orderItem)
        {
            if (numberOfOrders <= _maxItems)
            {
                Cost += orderItem.Cost;
                OrderItems[numberOfItems++] = orderItem;
            }
        }
        private void deliver()
        {
            deliveryTime = DateTime.Now;
        }

        public void Delivered()
        {
            Deliverd = true;
        }

        public string GetInfo()
        {
            string result = "";
            result += $"\n order id: {Id}\n order Type:{orderType}\n customer name: {Customer.Name}\n customer Id: {Customer.IdNumber}\n deliverty address:{DeliveryAddress.GetInfo()}\n order Time: {OrderTime}\n";
            if (Deliverd) { result += $"delivery Time: { DeliveryTime}"; }
            foreach (MenuItem item in OrderItems)
            {
                if (item != null)
                {
                    result += $"\n{item.GetInfo()}\n";
                }
            }
            result += $"\tTotal Cost{Cost}\n";
            return result;
        }
    }
}
