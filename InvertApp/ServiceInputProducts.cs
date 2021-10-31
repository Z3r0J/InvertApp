using System;

namespace InvertApp
{
    public class ServiceInputProducts
    {
        ServiceProduct ServiceProduct = new ServiceProduct();
        PrincipalMenu principalMenu = new PrincipalMenu();
        public void InputProducts()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            try
            {
                if (ProductExist() == true)
                {
                    ServiceProduct.List();

                    Console.WriteLine("Select the product to input: ");
                    int index = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please type the quantity to input: ");
                    int input = Convert.ToInt32(Console.ReadLine());

                    int Total = ItemRepository.Instancia.products[index-1].Quantity + input;
                    ItemRepository.Instancia.products[index - 1].Quantity = Total;
                    principalMenu.Menu();

                }
                principalMenu.Menu();
            }
            catch (Exception ex )
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
