using System;
using System.Collections.Generic;
using ASPNET.Models;

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

namespace ASPNET
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();

        //Add a new stubbed out method-  GetProduct() -
        //to the IProductRepository Interface
        public Product GetProduct(int id);

        // (int id) gives the method return parameters
        // in this case, returns an integer named id
        // todo implement the method in the ProductRepository class - DONE

        // todo IProductRepository - add the UpdateProduct stubbed out Method
        public void UpdateProduct(Product product);

        public void InsertProduct(Product productToInsert);

        public IEnumerable<Category> GetCategories();

        public Product AssignCategory();

        // todo Part Five Delete Products, Step 1 Create stubbed out
        // DeleteProduct() method
        public void DeleteProduct(Product product);


    }
}
