﻿using Product_Library.Entites;
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
                Console.WriteLine("3. Delete product");
                Console.WriteLine("4. Search product");
                userInput();
                Console.WriteLine("do you want to perform another operation in product?");
                choice = Console.ReadLine();
            } while (choice == "yes");

        }

        

        public static void userInput()
        {
            string choice;
            int input = Convert.ToInt32(Console.ReadLine());
            
            //List<Product> data = new List<Product>();
           
                if (input==1)
            {
                do
                {

                    Operations.AddProduct();
                    Console.WriteLine("do you want to add another product?(yes/no)");
                    choice = Console.ReadLine();

                } while (choice == "yes");
            }
               



            else if (input == 2)
            {
                Operations.listProducts();
            }

            else if (input == 3)
            {
                Operations.deleteProduct();
            }
            else if (input == 4)
            {
                Console.WriteLine("Enter name to search ");
                string name =Console.ReadLine();
                Operations.searchProduct(name);
            }
        }

    }
}
