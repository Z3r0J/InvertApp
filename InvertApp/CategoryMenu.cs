using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{
    public class CategoryMenu
    {
        public void MenuCategory()
        {
            Console.Clear();
            try
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1 - Add Category\n" + "2 - Edit Category\n" + "3 - Delete Category\n" + "4 - List Category\n" + "5 - Go Back");
                Console.Write("> ");
                int option = Convert.ToInt32(Console.ReadLine());
                ServiceCategory serviceCategory = new ServiceCategory();
                PrincipalMenu principalMenu = new PrincipalMenu();
                switch (option)
                {
                    case (int)MaintainEnum.Add:
                        serviceCategory.Add();
                        Console.ReadKey();
                        MenuCategory();
                        break;
                    case (int)MaintainEnum.Edit:
                        serviceCategory.Edit();
                        Console.ReadKey();
                        MenuCategory();
                        break;
                    case (int)MaintainEnum.Delete:
                        serviceCategory.Delete();
                        Console.ReadKey();
                        MenuCategory();
                        break;
                    case (int)MaintainEnum.List:
                        serviceCategory.List();
                        Console.ReadKey();
                        MenuCategory();
                        break;
                    case (int)MaintainEnum.Back:
                        principalMenu.Menu();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please insert a valid number.");
                Console.ReadKey();
                MenuCategory();
            }
        }
    }
}
