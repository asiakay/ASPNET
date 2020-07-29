using System;
using System.Collections.Generic;
//todo Add properties to the class that corresponds with Column Names:
//Part 4 Creating a product
//todo Step 2. Update using directive with System.Collections.Generic;
//Add a Property of type IEnumerable<Category> to the Product Model:


namespace ASPNET.Models
{
    public class Product
    {
        public Product()
        {
        }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
