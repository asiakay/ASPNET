using System;
using System.Collections.Generic;
using Dapper;
using Dapper.Contrib.Extensions;
//todo Add properties to the class that corresponds with Column Names:
//Part 4 Creating a column model
//todo Step 2. Update using directive with System.Collections.Generic;
//Add a Property of type IEnumerable<Category> to the Product Model:
//todo [dapper.Contrib.Extensions.Key] in Product Class
//todo add dependecy injection package
/*
 * shared view 
 */

namespace ASPNET.Models
{
    public class Employee
    {
        public Employee()
        {
        }
        [Dapper.Contrib.Extensions.Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Title { get; set; }
    }
        //[Dapper.Contrib.Extensions.Key]
        //public int EmployeeID { get; set; }
        //public string FirstName { get; set; }
        //public string MiddleInitial { get; set; }
        //public string LastName { get; set; }
        //public string EmailAddress { get; set; }
        //public string PhoneNumber { get; set; }
        //public string Title { get; set; }
        ////public IEnumerable<Category> Categories { get; set; }
    
}
