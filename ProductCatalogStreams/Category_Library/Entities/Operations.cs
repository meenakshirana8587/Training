using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Category_Library.Entities
{
    public class Operations


    {
        public static List<Category> data= new List<Category>();
        static string filepath = @"C:/Users/lenovo/source/repos/ProductCatalogStreams/productcatalogcsvfiles/category.csv";

        public static void AddCategory()
        {

           
            string lastLine = File.ReadLines(filepath).Last();

            int s = lastLine[0] - '0';
            Category.Cat_Id = s;
            //Console.WriteLine(s);












            Console.WriteLine("Please enter category name: ");


            string name = "";
            while (name.Length < 1)
            {
                Console.WriteLine("name is a required field ");
                name = Console.ReadLine();
            }








            Console.WriteLine("Please enter description: ");

            string description = "";
            while (description.Length < 1)
            {
                Console.WriteLine("manufacturer is a required field ");
                description = Console.ReadLine();
            }


            string shortcode = "";
            while (shortcode.Length < 1|| shortcode.Length>4)
            {
                Console.WriteLine("shortcode is a required field and should not be more than 4 characters");
                shortcode = Console.ReadLine();
            }





            var config = new CsvConfiguration(CultureInfo.InvariantCulture);
            config.HasHeaderRecord = false;
            Category p = new Category { Id = Category.Cat_Id, Name = name, Description = description, ShortCode= shortcode};
            Operations.data.Add(p);


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


        public static void listCategory()
        {
            string filepath = @"C:/Users/lenovo/source/repos/ProductCatalogStreams/productcatalogcsvfiles/category.csv";


            using (StreamReader input = File.OpenText(filepath))


            using (CsvHelper.CsvReader csvReader = new CsvHelper.CsvReader(input, System.Globalization.CultureInfo.CreateSpecificCulture("en-SI")))
            {
                IEnumerable<dynamic> records = csvReader.GetRecords<dynamic>();

                Console.WriteLine("Id\tName\tShortCode\tDescription");
                foreach (var record in records)
                {

                    Console.Write(record.Id + "\t");
                    Console.Write(record.Name + "\t");
                    Console.Write(record.ShortCode + "\t\t");
                    Console.WriteLine(record.Description + "\t\t");
                    
                }

            }
        }

        public static void deleteCategory()
        {
            List<Category> records;
            Console.WriteLine("Please enter the id of product Id you want to delete");
            int id = Convert.ToInt32(Console.ReadLine());

            using (var reader = new StreamReader(filepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                records = csv.GetRecords<Category>().ToList();

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


        public static void searchCategory(string searchName)
        {

            var strLines = File.ReadLines(filepath);
            foreach (var line in strLines)
            {

                if (line.Split(',')[1].Equals(searchName))
                {
                    Console.WriteLine(line);
                    return;
                }

            }

            //Console.WriteLine("record not found");


        }

    }
}
