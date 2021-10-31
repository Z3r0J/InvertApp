using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public class PrincipalMenu
    {
        
        public void Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" _______  _______  _______  ____          _______  _______  _   ___  ___     ");
            Console.WriteLine("|       ||  _    ||       ||    |        |  _    ||       || | |   ||   |    \n" +
                            "|____   || | |   ||____   | |   |  ____  | | |   ||   ____|| |_|   ||   |___ \n" +
                            " ____|  || | |   | ____|  | |   | |____| | | |   ||  |____ |       ||    _  |\n" +
                            "| ______|| |_|   || ______| |   |        | |_|   ||_____  ||___    ||   | | |\n" +
                            "| |_____ |       || |_____  |   |        |       | _____| |    |   ||   |_| |\n" +
                            "|_______||_______||_______| |___|        |_______||_______|    |___||_______|\n" +
                            "                                                                             \n" +
                            "                      Jean Carlos Reyes Encarnación                          \n");


            try
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("1 - Maintain of Category\n" + "2 - Maintain of Products\n" + "3 - Product Input\n" + "4 - Product Output\n" + "5 - Exit");
                Console.Write(">");
                int option = Convert.ToInt32(Console.ReadLine());
                CategoryMenu categoryMenu = new CategoryMenu();
                ProductMenu productMenu = new ProductMenu();
                ServiceInputProducts serviceInputProducts = new ServiceInputProducts();
                ServiceOutputProducts serviceOutputProducts = new ServiceOutputProducts();
                switch (option)
                {
                    case (int)MenuPrincipal.MaintainCategory:
                        categoryMenu.MenuCategory();
                        break;
                    case (int)MenuPrincipal.MaintainProduct:
                        productMenu.MenuProduct();
                        break;
                    case (int)MenuPrincipal.ProductInput:
                        serviceInputProducts.InputProducts();
                        break;
                    case (int)MenuPrincipal.ProductOutput:
                        serviceOutputProducts.OutputProducts();
                        break;
                    default:
                        Console.WriteLine("Thanks for using the system!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Please insert a valid number.");
                Console.ReadKey();
                Menu();
            }
            }

        }
    }
