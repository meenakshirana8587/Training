using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CsvHelper;

namespace Product_Library.Entites
{
    public class Operations


    {
        
        public static void AddProduct()
        {

            string choice;
            List<Product> data = new List<Product>();
            do
            {

                string filepath = @"C:/productcatalog/product.csv";








                Console.WriteLine("Please enter product name: ");

           
            Console.WriteLine("name is a required field ");
            string name = Console.ReadLine();
           


           
            

            
       

            Console.WriteLine("Please enter description: ");
            
            Console.WriteLine("description is a required field ");
            string description = Console.ReadLine();
            


            Console.WriteLine("Please enter product manufacturer: ");
            
            Console.WriteLine("manufacturer is a required field ");
           string manufacturer = Console.ReadLine();
           

            Console.WriteLine("Please enter product price: ");
           
            Console.WriteLine("price must be  greater than 0 ");
            int price = Convert.ToInt32(Console.ReadLine());


           


            using (StreamWriter input = new StreamWriter(filepath))
            using (CsvHelper.CsvWriter csvwriter = new CsvHelper.CsvWriter(input, System.Globalization.CultureInfo.CreateSpecificCulture("en-SI")))
            {



                    Product p = new Product { Id = Product.Prod_Id, Name = name, Description = description, Manufacturer = manufacturer, SellingPrice = price };
                    data.Add(p);
                 

            

                    csvwriter.WriteHeader<Product>();
                    csvwriter.NextRecord();


                    
                        csvwriter.WriteRecords(data);

                        input.Flush();
                   


               
                


            }

               




              
             
                Console.WriteLine("do you want to add another product?(yes/no)");
                choice = Console.ReadLine();

            } while (choice == "yes");
        }
        


        public static void listProducts()
        {
            string filepath = @"C:/productcatalog/product.csv";


            using (StreamReader input = File.OpenText(filepath))


                using (CsvHelper.CsvReader csvReader = new CsvHelper.CsvReader(input, System.Globalization.CultureInfo.CreateSpecificCulture("en-SI")))
                {
                    IEnumerable<dynamic> records = csvReader.GetRecords<dynamic>();

                Console.WriteLine("Id\tName\tDescription\tManufacturer\tPrice");
                    foreach (var record in records)
                    {

                        Console.Write(record.Id+"\t");
                        Console.Write(record.Name + "\t");
                        Console.Write(record.Description + "\t");
                        Console.Write(record.Manufacturer + "\t\t");
                        Console.WriteLine(record.SellingPrice + "\t");
                }

                }
            }
        }
   }



