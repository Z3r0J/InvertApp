using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public class ServiceProduct
    {
        Category Category = new Category("");
        ServiceCategory serviceCategory = new ServiceCategory();
        ProductMenu productMenu = new ProductMenu();
       public void Add()
        {
            try
            {
                if (ValidateCategory()== true)
                {
                    Console.WriteLine("Please type the Name: ");
                    Console.Write(">");
                    string name = Console.ReadLine();

                    Console.WriteLine("Please type the price: ");
                    Console.Write(">");
                    double price = Convert.ToDouble(Console.ReadLine());

                    serviceCategory.List();
                    Console.WriteLine("Please select the ID of the category: ");
                    Console.Write(">");
                    int category = Convert.ToInt32(Console.ReadLine());
                    Category.Name = ItemRepository.Instancia.category[category - 1].Name;

                    Products products = new Products(name,price,Category,0);
                    ItemRepository.Instancia.products.Add(products);
                    Console.WriteLine("The product is Add succesfully!");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void List()
        {
            int count = 1;
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("ID       Name            Price                 Category                Quantity      ");
            Console.WriteLine("**************************************************************************************");
            foreach (Products item in ItemRepository.Instancia.products)
            {
                Console.WriteLine($"{count}       {item.Name}            {item.Price}                 {item.Category.Name}                {item.Price}      {item.Quantity}");
                count++;
            }
        }
        public void ListOnlyName()
        {
            int count = 1;
            Console.WriteLine("*************");
            Console.WriteLine("*        Name *");
            Console.WriteLine("*************");
            foreach (Products item in ItemRepository.Instancia.products)
            {
                Console.WriteLine($"{count}       {item.Name}");
                count++;
            }
        }
        public void Delete()
        {
            Console.Clear();
            Console.WriteLine("**********************");
            Console.WriteLine("** DELETE PRODUCTS: **");
            Console.WriteLine("**********************");
            try
            {
                ListOnlyName();
                Console.WriteLine("Please insert the # of the product: ");
                Console.Write(">");
                int index = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Are you sure want you delete the product? (Y/N): ");
                string answer = Console.ReadLine();
                if (answer == "Y")
                {
                    ItemRepository.Instancia.products.RemoveAt(index-1);
                    Console.WriteLine("The product is delete sucessfully!");
                }
                else{
                    productMenu.MenuProduct();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please type a valid data");
                Console.ReadKey();
                Delete();
            }
        }

        public void Edit() {
            Console.Clear();
            Console.WriteLine("********************");
            Console.WriteLine("** EDIT PRODUCTS: **");
            Console.WriteLine("********************");
            try
            {
                ListOnlyName();
                if (ValidateCategory() == true)
                {
                    Console.WriteLine("Select the product to edit: ");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please type the new Name: ");
                    Console.Write(">");
                    string name = Console.ReadLine();

                    Console.WriteLine("Please type the new price: ");
                    Console.Write(">");
                    double price = Convert.ToDouble(Console.ReadLine());

                    serviceCategory.List();
                    Console.WriteLine("Please select the new ID of the category: ");
                    Console.Write(">");
                    int category = Convert.ToInt32(Console.ReadLine());
                    Category.Name = ItemRepository.Instancia.category[category - 1].Name;

                    Products products = new Products(name, price, Category, 0);
                    ItemRepository.Instancia.products.Add(products);
                    Console.WriteLine("The product is Add succesfully!");
                    Console.ReadKey();

                    Products Products = new Products(name,price,Category,Convert.ToInt32(products.Quantity));

                    ItemRepository.Instancia.products[index - 1] = Products;
                    Console.WriteLine("The product is update sucessfully!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please type a valid data");
                Console.ReadKey();
                Edit();
            }
        }

        public bool ValidateCategory()
        {
            if (ItemRepository.Instancia.category.Count<=0)
            {
                Console.WriteLine("In this moment the system don't have category, please insert a category");
                Console.ReadKey();
                return false;
            }
            return true;

        }
    }
}
