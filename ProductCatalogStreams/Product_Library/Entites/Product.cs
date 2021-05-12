//using Category_Library.Entities;
//using ProductCatalogStreams.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Product_Library.Entites
{
    public class Product 
    {
        public   int Id { get; set; }
        public string Manufacturer { get; set; } = "";
        
        //public List<Category> Categories;
       
        public int SellingPrice { get; set; } = 0;
        public string Name { get; set; }
        public string Description { get; set; }
        public static int Prod_Id;
        public Product()
        {
            Prod_Id = Prod_Id + 1;
            

        }


    }
}
