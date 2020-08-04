using System;
using System.Data;
using System.Collections.Generic;
using Dapper;
using ASPNET.Models;
using Dapper.Contrib.Extensions;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNET;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
/*
todo 21. set up our Controller: the Controller facilitates
handling a request and handing it to the correct view and model
We will add the following code inside of the
ProductController class

 ****Part Two****
todo 3. Create ViewProduct() method in the Product Controller

 ****Part Three****
todo 3. Create the UpdateProduct() Controller Method
todo 5. Add UpdateProductToDatabase() Method to ProductController

****Part Four**** Add a Product
todo Step 6. InsertProduct() Controller Method in the ProductController.
todo Step 7. InsertProductToDatabase() Controller Method in the ProductController

****Part Five**** Delete Products 
todo Step 3. ProductController - create DeleteProduct method
for the controller to trigger the task



*/

namespace ASPNET.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IEmployeeRepository erepo;


        public EmployeeController(IEmployeeRepository erepo)

        {
            this.erepo = erepo;
        }


        // GET: /<controller>/
        public IActionResult Index()

        {
            var employees = erepo.GetAllEmployees();
            return View(employees);
        }

        public IActionResult ViewEmployee(int id)

        {
            var employee = erepo.GetEmployee(id);
            return View(employee);
        }
        // we are passing in product as an argument in the view method
        // to serve as the Model we will work within our ViewProduct.cshtml
        // we are about to create in Part Two Step 4. 

        //Part Three Step 3.
        //Create the UpdateProduct() Controller Method in the ProductController :

        public IActionResult UpdateEmployee(int id)
        {
            Employee empl = erepo.GetEmployee(id);

            erepo.UpdateEmployee(empl);

            if (empl == null)
            {
                return View("EmployeeNotFound");
            }
            return View(empl);
        }

        public IActionResult UpdateEmployeeToDatabase(Employee employee)
        {
            erepo.UpdateEmployee(employee);

            return RedirectToAction("ViewEmployee", new { id = employee.EmployeeID });

        }


        //public IActionResult InsertEmployee()
        //{
        //    var empl = _e_repo.AssignCategory();

        //    return View(empl);
        //}


        public IActionResult InsertEmployeeToDatabase(Employee employeeToInsert)
        {
            erepo.InsertEmployee(employeeToInsert);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEmployee(Employee employee)
        {
            erepo.DeleteEmployee(employee);

            return RedirectToAction("Index");


        }

    }
}



//todo Part Four Add Product, Step 7. InsertProductToDatabase() Controller Method 

//todo created DeleteProduct method for the controller to trigger the task
