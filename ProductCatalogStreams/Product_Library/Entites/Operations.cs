using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Category_Library.Entities;
using CsvHelper;
using CsvHelper.Configuration;

namespace Product_Library.Entites
{
    public class Operations


    {
        static string filepath = @"C:/Users/lenovo/source/repos/ProductCatalogStreams/productcatalogcsvfiles/product.csv";

        public static void AddProduct()
        {
            
            List<Product> data = new List<Product>();
            string lastLine = File.ReadLines(filepath).Last();

            int s = lastLine[0] - '0';
            Product.Prod_Id = s;
            //Console.WriteLine(s);










            string name = "";

            Console.WriteLine("Please enter product name: ");

            while (name.Length < 1)
            {
                Console.WriteLine("name is a required field ");
                name = Console.ReadLine();
                
            }
            Console.WriteLine("Please enter product shortcode: ");

            string shortcode="";
            while (shortcode.Length < 1 || shortcode.Length > 4)
            {
                Console.WriteLine("shortcode is a required field ");

                shortcode = Console.ReadLine();
            }

            Console.WriteLine("Please enter product category: ");


            Console.WriteLine("category is a required field ");
           
                List<Category> records;
                
                using (var reader = new StreamReader(@"C:/Users/lenovo/source/repos/ProductCatalogStreams/productcatalogcsvfiles/category.csv"))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    records = csv.GetRecords<Category>().ToList();

                records.ForEach(i => Console.WriteLine(i.Id + " " + i.Name));
                

                
            }

            List<Category> productCategories = new List<Category>();
            string choice;
            string Cname=" ";
            do
            {
                Console.WriteLine("GIVE CATEGORY ID ");
                int id = Convert.ToInt32(Console.ReadLine());
                var datas = records.Single((a) => a.Id == id);
                if (datas != null)
                    productCategories.Add(datas);
                productCategories.ForEach(i => Cname = Cname+ i.Name );
                
                Console.WriteLine("FOR ADDING MORE CATEGORY : yes , else : no ");
                choice = Console.ReadLine();
            } while (choice == "yes");




            
           









            Console.WriteLine("Please enter description: ");
            string description = "";
            while (description.Length < 1)
            {
                Console.WriteLine("description is a required field ");
                description = Console.ReadLine();
            }



            Console.WriteLine("Please enter product manufacturer: ");

            string manufacturer = "";
            while (manufacturer.Length < 1)
            {
                Console.WriteLine("manufacturer is a required field ");
                manufacturer = Console.ReadLine();
            }




            Console.WriteLine("Please enter product price: ");

            int price = 0;
            while (price <= 0)
            {
                Console.WriteLine("price should be more than 0 ");
                price = Convert.ToInt32(Console.ReadLine());
            }


            var config = new CsvConfiguration(CultureInfo.InvariantCulture);
            config.HasHeaderRecord = false;
            Product p = new Product { Id = Product.Prod_Id, Name = name, Description = description, Manufacturer = manufacturer, SellingPrice = price, ShortCode = shortcode, Category= Cname };

            data.Add(p);


            using (var input = new StreamWriter(filepath, true))
            using (CsvHelper.CsvWriter csvwriter = new CsvHelper.CsvWriter(input, config))
            {







                //if (File.Exists(filepath))
                //{
                //    //File.Create(filepath);
                //    csvwriter.WriteHeader<Product>();
                //}
                //csvwriter.NextRecord();



                csvwriter.WriteRecords(data);


                input.Flush();





            }



















        }


        public static void listProducts()
        {
            string filepath = @"C:/Users/lenovo/source/repos/ProductCatalogStreams/productcatalogcsvfiles/product.csv";


            using (StreamReader input = File.OpenText(filepath))


            using (CsvHelper.CsvReader csvReader = new CsvHelper.CsvReader(input, System.Globalization.CultureInfo.CreateSpecificCulture("en-SI")))
            {
                IEnumerable<dynamic> records = csvReader.GetRecords<dynamic>();

                Console.WriteLine("Id\tName\tDescription\tManufacturer\tPrice\tCategory\t\tShortCode");
                foreach (var record in records)
                {

                    Console.Write(record.Id + "\t");
                    Console.Write(record.Name + "\t");
                    Console.Write(record.Description + "\t\t");
                    Console.Write(record.Manufacturer + "\t\t");
                    Console.Write(record.SellingPrice + "\t");
                    Console.Write(record.Category + "\t");
                    Console.WriteLine(record.ShortCode + "\t");
                }

            }
        }

        public static void deleteProduct()
        {
            List<Product> records;
            Console.WriteLine("Please enter the id of product Id you want to delete");
            int id = Convert.ToInt32(Console.ReadLine());

            using (var reader = new StreamReader(filepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<Product>().ToList();

                for (int i = 0; i < records.Count; ++i)
                {
                    if (records[i].Id == id)
                    {
                        records.RemoveAt(i);
                    }
                }
            }

            using (var writer = new StreamWriter(filepath))
            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteRecords(records);
            }
        }


        public static void searchProduct(string searchName)
        {
            
                var strLines = File.ReadLines(filepath);
                foreach (var line in strLines)
                {
                
                if (line.Split(',')[3].Equals( searchName))
                {
                    Console.WriteLine(line);
                    return;
                }
                
                }

            //Console.WriteLine("record not found");

                
            }

        }
    


   }



