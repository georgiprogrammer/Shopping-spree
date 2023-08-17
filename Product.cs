using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_spree.Modules
{
    class Product
    {
        private string name;
        private int cost;
        public string Name
        {
            get { return name; }
            set
            {
               
                this.name = value;
            }
        }
        public int Cost
        {
            get { return cost; }
            set
            {
               
                this.cost = value; }
        }
        public Product(string name, int cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

    }
}
