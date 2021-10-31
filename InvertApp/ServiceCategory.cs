using System;
using System.Collections.Generic;
using System.Text;

namespace InvertApp
{

    public class ServiceCategory
    {
        CategoryMenu categoryMenu = new CategoryMenu();
       public void Add()
        {
            Console.WriteLine("Please type the Name: ");
            Console.Write(">");
            string name = Console.ReadLine();

            Category category = new Category(name);
            ItemRepository.Instancia.category.Add(category);
            Console.WriteLine("The Category is Add succesfully!");
            Console.ReadKey();
        }

        public void List()
        {
            int count = 1;
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Name:                                                                     ");
            Console.WriteLine("****************************************************************************");
            foreach (Category item in ItemRepository.Instancia.category)
            {
                Console.WriteLine($"{count} - {item.Name}");
                count++;
            }
        }
        public void Delete()
        {
            Console.WriteLine("**********************");
            Console.WriteLine("** DELETE CATEGORY: **");
            Console.WriteLine("**********************");
            try
            {
                Console.Clear();
                if (ValidateCategory()==false)
                {
                    categoryMenu.MenuCategory();
                }
                List();
                Console.WriteLine("Please select the ID of the category: ");
                Console.Write(">");
                int index = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Are you sure want you delete the category? (Y/N): ");
                string answer = Console.ReadLine();
                if (answer == "Y")
                {
                    ItemRepository.Instancia.category.RemoveAt(index - 1);
                    Console.WriteLine("The category is delete sucessfully!");
                }
                else
                {
                    categoryMenu.MenuCategory();
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
            Console.WriteLine("** EDIT CATEGORY: **");
            Console.WriteLine("********************");
            try
            {
                if (ValidateCategory() == true)
                {
                    List();
                    Console.WriteLine("Please select the ID of the category: ");
                    Console.Write(">");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please type the new name: ");
                    Console.Write(">");
                    string name = Console.ReadLine();

                    Category category = new Category(name);

                    ItemRepository.Instancia.category[index - 1] = category;

                    Console.WriteLine("The category is update sucessfully!");
                }

                categoryMenu.MenuCategory();
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
            if (ItemRepository.Instancia.category.Count <= 0)
            {
                Console.WriteLine("In this moment the system don't have category, please insert a category");
                Console.ReadKey();
                return false;
            }
            return true;

        }
    }
}
