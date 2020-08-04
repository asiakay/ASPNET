using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Dapper;
using Dapper.Contrib.Extensions;

//todo Add properties to the class that corresponds with Column Names:
//Part 4 Creating a product
//todo Step 2. Update using directive with System.Collections.Generic;
//Add a Property of type IEnumerable<Category> to the Product Model:
//todo [dapper.Contrib.Extensions.Key] in Product Class
//todo add dependecy injection package
/*
 * shared view 
 */

namespace ASPNET.Models
{
    public class Product
    {
        public Product()
        {
        }
        [Dapper.Contrib.Extensions.Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage ="This field is required. Please enter the product name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required. Please enter the product name.")]
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public int OnSale { get; set; }
        public int StockLevel { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
