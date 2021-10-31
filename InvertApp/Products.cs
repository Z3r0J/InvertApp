using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public int Quantity { get; set; }

        public Products()
        {

        }
        public Products(string name, double price, Category category, int quantity)
        {
            Name = name;
            Price = price;
            Category = category;
            Quantity = quantity;
        }
    }
}
