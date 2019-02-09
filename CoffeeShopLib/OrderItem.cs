using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class OrderItem
    {
        private MenuItem[] menuItems;

        public MenuItem[] MenuItems
        {
            get { return menuItems; }
            set { menuItems = value; }
        }

        public OrderItem(MenuItem[] menuItem)
        {
            MenuItems = menuItem;
        }

        public string GetInfo()
        {
            string result = "";
            foreach (MenuItem item in menuItems)
            {
                if(item != null)
                {
                    result += $"\n\t Orderd Food: {item.Name} description:{item.Description} Cost: {item.Cost}\n";
                }
            }
            return result;
        }
    }
}
