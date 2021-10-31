using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public sealed class ItemRepository
    {
        public static ItemRepository Instancia { get; } = new ItemRepository();
        public List<Category> category = new List<Category>();
        public List<Products> products = new List<Products>();
        private ItemRepository()
        {

        }
    }
}
