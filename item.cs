using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Item
    {
        private string name;
        private int price;
        private int stock;

        public Item(string name, int price, int stock)
        {
            this.name = name;
            this.price = price;
            this.stock = stock;
            this.Quantity = 0;
            this.RequiredAmount = 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public int Quantity { get; set; }
        public int RequiredAmount { get; set; }


        public bool HasEnoughStock()
        {
            return Quantity >= RequiredAmount;
        }

        public void UseItem()
        {
            if (HasEnoughStock())
            {
                Quantity -= RequiredAmount;
                Console.WriteLine($"{Name} used. Remaining: {Quantity}g");
            }
            else
            {
                Console.WriteLine($"Not enough {Name} in stock.");
            }
        }

        public void Refill(int amount)
        {
            Quantity += amount;
            Console.WriteLine($"{Name} refilled. New stock: {Quantity}g");
        }
    }
}
