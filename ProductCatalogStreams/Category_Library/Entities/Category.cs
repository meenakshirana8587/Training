using System;
using System.Collections.Generic;
using System.Text;

namespace Category_Library.Entities
{
    public class Category
    {
        public int Id { get; set; }



        public string ShortCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public static int Cat_Id;
        public Category()
        {
            Cat_Id = Cat_Id + 1;


        }


    }
}
