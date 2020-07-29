using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNET;
using ASPNET.Models;

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
    public class ProductController : Controller
    { 
        private readonly IProductRepository repo;

    public ProductController(IProductRepository repo)
    {
        this.repo = repo;
    }


        // GET: /<controller>/
    public IActionResult Index()

    {
            var products = repo.GetAllProducts();
            return View(products);
    }

    public IActionResult ViewProduct(int id)

    {
            var product = repo.GetProduct(id);
            return View(product);
    }
        // we are passing in product as an argument in the view method
        // to serve as the Model we will work within our ViewProduct.cshtml
        // we are about to create in Part Two Step 4. 

        //Part Three Step 3.
        //Create the UpdateProduct() Controller Method in the ProductController :

    public IActionResult UpdateProduct(int id)
        {
            Product prod = repo.GetProduct(id);

            repo.UpdateProduct(prod);

            if (prod == null)
            {
                return View("ProductNotFound");
            }
            return View(prod);
        }

    public IActionResult UpdateProductToDatabase(Product product)
        {
            repo.UpdateProduct(product);

            return RedirectToAction("ViewProduct", new { id = product.ProductID });

        }

        //todo Part Four Add Product, Step 6. InsertProduct() Controller Method.

    public IActionResult InsertProduct()
        {
            var prod = repo.AssignCategory();

            return View(prod);
        }

        //todo Part Four Add Product, Step 7. InsertProductToDatabase() Controller Method 

    public IActionResult InsertProductToDatabase(Product productToInsert)
        {
            repo.InsertProduct(productToInsert);
            return RedirectToAction("Index");
        }
        //todo create DeleteProduct method for the controller to trigger the task

    public IActionResult DeleteProduct(Product product)
        {
            repo.DeleteProduct(product);

            return RedirectToAction("Index");


        }

    }
}
