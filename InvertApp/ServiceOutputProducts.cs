using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public class ServiceOutputProducts
    {
        ServiceProduct ServiceProduct = new ServiceProduct();
        PrincipalMenu principalMenu = new PrincipalMenu();
        public void OutputProducts()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            try
            {
                if (ProductExist() == true)
                {
                    ServiceProduct.List();

                    Console.WriteLine("Select the product to output: ");
                    int index = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please type the quantity to output: ");
                    int input = Convert.ToInt32(Console.ReadLine());

                    if (input > ItemRepository.Instancia.products[index-1].Quantity)
                    {
                        Console.WriteLine("You are putting a quantity more than the actual.");
                        Console.ReadKey();
                        principalMenu.Menu();
                    }
                    int Total = ItemRepository.Instancia.products[index - 1].Quantity + input;
                    ItemRepository.Instancia.products[index - 1].Quantity = Total;
                    principalMenu.Menu();

                }
                principalMenu.Menu();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public bool ProductExist()
        {
            if (ItemRepository.Instancia.products.Count <= 0)
            {
                Console.WriteLine("In this moment the system don't have product, please insert a product");
                Console.ReadKey();
                return false;

            }
            return true;
        }
    }
}
