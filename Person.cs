using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_spree.Modules
{
    class Person
    {
        private string name;
        private int money;
        private List<string> bag;
        public string Name
        {
            get { return name; }
            set
            {
                
                this.name = value; }
        }
        public int Money
        {
            get { return money; }
            set
            {
                
                this.money = value; }
        }
        public List<string> Bag
        {
            get { return bag; }
            set { this.bag = value; }
        }
        public Person(string name, int money, List<string> bag)
        {
            this.Name = name;
            this.Money = money;
            this.Bag = bag;
        }
    }
}
