using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    public class MenuItem
    {
        private string name;
        private string description;
        private decimal cost;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }


        public MenuItem(string name, string description, decimal cost)
        {
            Name = name;
            Description = description;
            Cost = cost;
        }


        public string GetInfo()
        {
            return $"Food: {Name}, Description:{Description} Cost:{Cost}";
        }
    }
}
