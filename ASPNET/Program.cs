/*TODO 1) Fork and Clone this repository https://github.com/mvdoyle/ASPNET

//TODO 2) Delete your appsettings.json file
//TODO Right click project folder select Display options if hidden files are unseen in solution
//TODO 3) Configure.gitignore file to ignore appsettings.json
//TODO 4) git add .
//TODO 5) git commit -m “deleted file”
//TODO 6) Click on the Project and Add a new appsettings.json file to your ASP.NET application:
todo 7) Do a git status to make sure that git is not tracking your appsettings.json file
todo 8) Add connection string information in appsettings.json.
todo 9) Create our Product Model.
todo 10) Add Dapper and MySql.Data Nuget Packages (Make sure to accept the License Agreements).
todo 11) Create the IProductRepository Interface
todo For now, we will just add one stubbed out method → GetAllProducts
todo 12) Create the ProductRepository Class that will conform to the IProductRepository:
todo 13) Add private readonly IDbConnection _conn; as a class member
todo update using directive System.Data
todo 14) Setup the constructor so that it will accept an
IDbConnection as an argument and store that argument in _conn
todo 15) Create the GetAllProducts method
This method will utilize Dapper to query our BestBuy database
This method will return a collection of Product - IEnumerable<Product>
todo 16) Create a Product Folder inside of the Views Folder:
This folder will hold all of the Views (or web pages) that pertain to Products
todo 17) Add a new View (.cshtml) file to the Product Folder:
Name the file Index
todo 18) Start building .cshtml View
todo 19) IoC (Inversion of Control) Configuration:
Follow the steps in this document:
IoC Configuration https://docs.google.com/document/d/1Yc4m-pfc1R0gPSRqQoIZ8dc8GXX3WQa8UXt7S1KoqQM/edit?usp=sharing
        open Startup.cs --> 
        Add code from the IoC Configuration document
        to the ConfigureServices method
 todo 20. Now add our ProductController to the Controller folder:
https://docs.google.com/document/d/1GbCDvMYxkZNBL2fMGwgplly_cY3lv9iDsiamNiRxVxo/edit#bookmark=id.8t1pbtk9glei

todo 21)  set up our Controller: the Controller facilitates
handling a request and handing it to the correct view and model
We will add the following code inside of the
ProductController class
todo Add ASPNET.models to using directives in ProductRepository.
todo Add System.Data; to using directives in Startup.cs
todo Add MySql.Data.MySqlClient; to using directives in Startup,cs
todo Fix CS5001 Error "Program does not contain a static 'Main' method entry point."
todo 22) Create a link that will allow the user to access the Products View page:
todo Check this code ********Find the _Layout.cshtml file
    Change asp-controller=“Home” to asp-controller=“Product”
    Change asp-action=”Privacy” to asp-action=”Index” 
    Finally, change >Privacy</a> to >Products</a>
**** Part Two View Individual Product ****
todo 1. Add a new stubbed out method-  GetProduct() -
to the IProductRepository Interface.
todo 2. Create the GetProduct() method implementation in the ProductRepository class:
We will use the QuerySingle<Product> Dapper method so that we can return a single row 
todo 3. Create ViewProduct() method in the Product Controller
todo 4. Create the ViewProduct.cshtml
todo 5. Now we go to our Index.cshtml file and make each ProductID on our Index page a link that will take us to an individual product
In our Index.cshtml View for Product, we’ll add some html to do this:
<td><a href=/Product/ViewProduct/@product.ProductID>@product.ProductID</a></td>
**** Part Three: Update Product**** 
todo 1. IProductRepository - add the UpdateProduct stubbed out Method
todo 2. Create the UpdateProduct() ProductRepository Method Implementation
todo 3. Create the UpdateProduct() Controller Method
todo 4. Create the UpdateProduct.cshtml View file
todo 5. Add UpdateProductToDatabase() Method to ProductController 
****Part Four Create a Product ****
todo Step 1. Create a Category Model Class to set the proerties 
todo Step 2. Update using directive with System.Collections.Generic;
Add a Property of type IEnumerable<Category> to the Product Model:
todo Step 3. Edit IProductRepository Interface
- add the InsertProduct() stubbed out Method
- add the GetCategories() stubbed out Method
- add the AssignCategory() stubbed out Method
todo Step 4. Create Implementation of the InsertProduct() in the ProductRepository
todo Step 5. Create Implementation of the GetCategories()method and the
AssignCategory() method in the ProductRepository.
todo Step 6. InsertProduct() Controller Method in the ProductController.
todo Step 7. InsertProductToDatabase() Controller Method in the
ProductController 
todo Step 8. Create InsertProduct View
todo Step 9. Add the following HTML code to the Product Index.cshtml View:
<div style="display: block">
    <a href="/Product/InsertProduct/">Create a New Product</a>
</div>
**** Part Five: Delete Products****
todo Step 1. IProductRepository - stubbed out DeleteProduct method
todo Step 2. ProductRepository - create implementation of the DeleteProduct method
todo Step 3. ProductController - create DeleteProduct method for the controller to trigger the task
todo Step 4. ViewProduct.cshtml View - add html to allow user to trigger DeleteProduct ProductController method
<div style="display: block">
    @using (Html.BeginForm("DeleteProduct", "Product", "Post"))
    {
        <input type="hidden" asp-for="ProductID" value="@Model.ProductID" />
        <input type="submit" onclick="return confirm('Are you sure?')" value="Delete this product" />
    }
</div>
Add a view https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-view?view=aspnetcore-3.1&tabs=visual-studio
todo Step 1. Right click on the Views folder, and then Add > New Folder and
name the folder HelloWorld.
todo Right click on the Views/HelloWorld folder, and then Add > New Item.
todo In the Add New Item - dialog
Select Razor View
Keep the Name box value, Index.cshtml.
Select Add or New.
todo Replace the contents of the Views/HelloWorld/Index.cshtml Razor view
file with the following:
@{
    ViewData["Title"] = "Index";
}

<h2>Index</h2>

<p>Hello from our View Template!</p>







todo Add additional HTML to the Index.cshtml View file
todo Add additional HTML to the ViewProduct.cshtml View file
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ASPNET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
