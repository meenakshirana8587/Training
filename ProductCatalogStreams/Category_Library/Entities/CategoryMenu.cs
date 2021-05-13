using System;
using System.Collections.Generic;
using System.Text;

namespace Category_Library.Entities
{
    public class CategoryMenu
    {
        public static void categorymenu()
        {
            string choice;
            do
            {


                Console.WriteLine("1. Add Category");
                Console.WriteLine("2. List Category");
                Console.WriteLine("3. Delete Category");
                Console.WriteLine("4. Search Category");
                userInput();
                Console.WriteLine("do you want to perform another operation in category?");
                choice = Console.ReadLine();
            } while (choice == "yes");

        }
        public static void userInput()
        {
            string choice;
            int input = Convert.ToInt32(Console.ReadLine());

            //List<Product> data = new List<Product>();

            if (input == 1)
            {
                do
                {

                    Operations.AddCategory();
                    Console.WriteLine("do you want to add another category?(yes/no)");
                    choice = Console.ReadLine();

                } while (choice == "yes");
            }




            else if (input == 2)
            {
                Operations.listCategory();
            }

            else if (input == 3)
            {
                Operations.deleteCategory();
            }
            else if (input == 4)
            {
                Console.WriteLine("Enter name to search ");
                string name = Console.ReadLine();
                Operations.searchCategory(name);
            }
        }

    }
}
