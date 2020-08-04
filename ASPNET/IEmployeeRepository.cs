using System;
using System.Data;
using System.Collections.Generic;
using Dapper;
using ASPNET.Models;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

/*todo For now, we will just add one stubbed out method → GetAllProducts
//todo check using directive
**** Part 2 ****
*todo 1) Add a new stubbed out method-  GetProduct() - 
*to the IProductRepository Interface.
**** Part 3 Update Product**** 
todo 1. IProductRepository - add the UpdateProduct stubbed out Method
**** Part Four Create a Product ****
todo Step 3. In the interface IProductRepository, add stubbed out methods:
    InsertProduct(), GetCategories(), AssignCategories()
**** Part Five Delete Products ****
todo Step 1. IProductRepository - stubbed out DeleteProduct method
*/
// (int id) gives the method parameters to act upon 
// in this case,return parameters returns an integer named id
// todo implement the method in the ProductRepository class - DONE

// todo IEmployeeRepository - add the UpdateProduct stubbed out Method

// (int id) gives the method parameters to act upon 
// in this case,return parameters returns an integer named id
// todo implement the method in the ProductRepository class - DONE

// todo IEmployeeRepository - add the UpdateProduct stubbed out Method


namespace ASPNET
{
    public interface IEmployeeRepository
    {
        public void InsertEmployee(Employee employeeToInsert);

        public IEnumerable<Employee> GetAllEmployees();

        public Employee GetEmployee(int id);

        public void UpdateEmployee(Employee employee);


        public void DeleteEmployee(Employee employee);
       

        /* methods'scope are declared in EmployeeRepository */  


    }
}





