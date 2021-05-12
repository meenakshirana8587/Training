using Product_Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductCatalogStreams.Entities
{
    public class MainMenu
    {
        public static void mainMenu()
        {
            Console.WriteLine("1. Products");
            Console.WriteLine("2. Categories");
            Console.WriteLine("3. Exit");
            userinput();

        }

        public static void userinput()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if(input==1)
            {
                ProductMenu.productmenu();
            }
        }

    }
}
