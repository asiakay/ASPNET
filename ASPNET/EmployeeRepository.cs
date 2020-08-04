﻿using System;
using System.Data;
using System.Collections.Generic;
using Dapper;
using ASPNET.Models;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
/*
todo Create the ProductRepository Class that will conform to
the IProductRepository.
todo Add private readonly IDbConnection _conn; as a class member
todo update using directive System.Data
todo Setup the constructor so that it will accept an
IDbConnection as an argument and store that argument in _conn
todo Create the GetAllProducts method
Add Dapper using directive and use the GetAllProducts method to utilize Dapper
to query our BestBuy database.
This method will return a collection of Product - IEnumerable<Product>
** Access IEnumerable with the Systems.Collections.Generic using directive
*
**** Part 2
todo Create the GetProduct() method implementation in the ProductRepository class:
We will use the QuerySingle<Product> Dapper method so that we can return a single row 
**** Part Three: Update Product
todo Step 2. Create the UpdateProduct() ProductRepository method Implementation:
**** Part Four Create a Product ****
todo Step 4. Create Implementation of the InsertProduct() in the ProductRepository
todo Step 5. Create Implementation of the GetCategories() method in the ProductRepository,
Create Implementation of the AssignCategory() Method in the ProductRepository
**** Part Five Delete Products ****
//todo Step 2. ProductRepository - create implementation of the DeleteProduct method
 */

namespace ASPNET
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDbConnection _conn;
        /* 
        todo Setup the constructor so that it will accept an
        IDbConnection as a parameter argument
        */
        public EmployeeRepository(IDbConnection conn)
        {
            //todo store that parameter argument in the _conn field
            _conn = conn;
        }

        public IEnumerable<Employee> GetAllEmployees()
        // IEnumerable supports a simple iteration over a collection
        // of a specified type
        {
            //return _conn.Query<Product>("SELECT * FROM employees;");
            return _conn.GetAll<Employee>(); // Dapper.Contrib Dependency

            // Return type is the connection to the data source
            //and query results from database
        }
        public Employee GetEmployee(int id)
        {
            return (Employee)_conn.QuerySingle<Employee>
                ("SELECT * FROM employees WHERE employeeID = @id",
                new { id });
        }

        // todo 2. Create the UpdateProduct() ProductRepository Method Implementation:

        public void UpdateEmployee(Employee employee)

        {
            _conn.Execute("UPDATE employees SET FirstName = @firstName, "
                + "MiddleInitial = @middleInitial, LastName = @lastName,"
                + "EmailAddress = @emailAddress, PhoneNumber = @phoneNumber,"
                + "Title = @title WHERE EmployeeID = @employeeID",
                new
                {
                    employeeID = employee.EmployeeID,
                    firstName = employee.FirstName,
                    middleInitial = employee.FirstName,
                    lasttName = employee.LastName,
                    emailAddress = employee.EmailAddress,
                    phoneNumber = employee.PhoneNumber,
                    title = employee.Title
                });
        }

        //todo Create Implementation of the InsertProduct() in the ProductRepository

        public void InsertEmployee(Employee employeeToInsert)
        {
            _conn.Execute("INSERT INTO employees (FirstName, MiddleInitial, LastName, EmailAddress, PhoneNumber, Title) VALUES (@firstName, @middleInitial, @lastName, @emailAddress, @phoneNumber, @title);",
                new { firstName = employeeToInsert.FirstName, middleInitial = employeeToInsert.MiddleInitial, lastName = employeeToInsert.LastName, emailAddress = employeeToInsert.EmailAddress, phoneNumber = employeeToInsert.PhoneNumber, title = employeeToInsert.Title});
        }
        // todo Step 5. Create Implementation of the GetCategories()Method, and AssignCategory() method.
       /* public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM categories;"); // regular dapper 

        }
        //public Product AssignCategory()
        //{
        //    var categoryList = GetCategories();
        //    var product = new Product();
        //    product.Categories = categoryList;

        //    return product;
        //}
       */

        // todo Step 2. Create implementation of the DeleteProduct method.
        public void DeleteEmployee(Employee employee)
        {
            _conn.Execute("DELETE FROM employees WHERE EmployeeID=@id;",
                new { id = employee.EmployeeID });

            _conn.Execute("DELETE FROM Sales WHERE ProductID=@id;",
                new { id = employee.EmployeeID });
        }



        // Create the GetProduct() method implementation in the ProductRepository class:
        // We will use the QuerySingle<Product> Dapper method so that we can return a single row
        /* Product is a public class, we access to implement the 
         * GetProduct() method on the readonly database field
         * .QuerySingle Extension executes a single row query, returning 
         * the daya typed as T
         https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-type-parameters
         */

    }
}
