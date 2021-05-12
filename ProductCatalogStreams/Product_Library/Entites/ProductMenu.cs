using Product_Library.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Library
{
    public class ProductMenu
    {
        public static void productmenu()
        {
            string choice;
            do
            {


                Console.WriteLine("1. Add product");
                Console.WriteLine("2. List product");
                userInput();
                Console.WriteLine("do you want to perform another operation in product?");
                choice = Console.ReadLine();
            } while (choice == "yes");

        }

        public static void userInput()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if(input==1)
            {
                Operations.AddProduct();
            }
            else if (input == 2)
            {
                Operations.listProducts();
            }
        }

    }
}
