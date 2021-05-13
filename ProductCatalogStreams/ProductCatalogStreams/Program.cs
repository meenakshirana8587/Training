using Product_Library.Entites;
using ProductCatalogStreams.Entities;
using System;

namespace ProductCatalogStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;


            // MainMenu mm = new MainMenu();
            do
            {
                MainMenu.mainMenu();
                Console.WriteLine("do you want to perform another operation?(yes/no)");
                choice = Console.ReadLine();
            } while (choice == "yes");
        }
    }
}
