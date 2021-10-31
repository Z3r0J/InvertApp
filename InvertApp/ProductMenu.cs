using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public class ProductMenu
    {
        public void MenuProduct()
        {
            Console.Clear();
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1 - Add Product\n" + "2 - Edit Product\n" + "3 - Delete Product\n" + "4 - List Product\n" + "5 - Go Back");
                Console.Write("> ");
                int option = Convert.ToInt32(Console.ReadLine());
                ServiceProduct serviceProduct = new ServiceProduct();
                PrincipalMenu principalMenu = new PrincipalMenu();
                switch (option)
                {
                    case (int)MaintainEnum.Add:
                        serviceProduct.Add();
                        Console.ReadKey();
                        MenuProduct();
                        break;
                    case (int)MaintainEnum.Edit:
                        serviceProduct.Edit();
                        Console.ReadKey();
                        MenuProduct();
                        break;
                    case (int)MaintainEnum.Delete:
                        serviceProduct.Delete();
                        Console.ReadKey();
                        MenuProduct();
                        break;
                    case (int)MaintainEnum.List:
                        serviceProduct.List();
                        Console.ReadKey();
                        MenuProduct();
                        break;
                    case (int)MaintainEnum.Back:
                        principalMenu.Menu();
                        break;
                    default:
                        Console.ReadKey();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please insert a valid number.");
                Console.ReadKey();
                MenuProduct();

            }
        }
    }
}
