using System;
using System.Collections.Generic;
using ASPNET.Models;
using System.Data;

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
    public interface IReviewRepository
    {
        public void InsertReview(Review reviewToInsert);

        public IEnumerable<Review> GetAllReviews();

        public Review GetReview(int id);

        public void UpdateReview(Review review);


        public Review AssignCategory();

        public Review AssignRating();

        public void DeleteReview(Review review);

        public IEnumerable<Category> GetCategories();

        public IEnumerable<Rating> GetRatings();

    }
}
