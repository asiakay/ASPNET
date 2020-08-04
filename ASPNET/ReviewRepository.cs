using System;
using System.Data;
using System.Collections.Generic;
using Dapper;
using ASPNET.Models;
using Dapper.Contrib;
using Dapper.Contrib.Extensions;

namespace ASPNET
{
    public class ReviewRepository : IReviewRepository
    {
        
        private readonly IDbConnection _conn;
        public ReviewRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Review> GetAllReviews()
        {
            return _conn.GetAll<Review>(); // Dapper.Contrib Dependency
        }
        public Review GetReview(int id)
        {
            return (Review)_conn.QuerySingle<Review>
                ("SELECT * FROM reviews WHERE reviewID = @id",
                new { id = id });
        }
        public void UpdateReview(Review review)
        {
            _conn.Execute("UPDATE reviews SET ReviewID = @rid, ProductID = @id, Reviewer = @reviewer, Rating = @rating, Comment = @comment, CategoryID = @categoryID WHERE ReviewID = @rid",
                new { rid = review.ReviewID, productID = review.ProductID, reviewer = review.Reviewer, rating = review.Ratings, comment = review.Comment, category = review.Categories });
        }
        public void InsertReview(Review reviewToInsert)
        {
            _conn.Execute("INSERT INTO reviews (reviewID, productID, reviewer, rating, comment, categoryID");
        }

        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM categories;");
        }

        public IEnumerable<Rating> GetRatings()
        {
            return _conn.Query<Rating>("SELECT * FROM ratings;");
        }

        public Review AssignCategory()
        {
            var categoryList = GetCategories();
            var review = new Review();
            review.Categories = categoryList;

            return review;
        }
        public Review AssignRating()
        {
            var ratingScore = GetRatings();
            var rating = new Review();
            return rating;
        }
        public void DeleteReview(Review review)
        {
            _conn.Execute("DELETE FROM reviews WHERE ReviewID=@rid;",
                new { rid = review.ReviewID});
        }
    }
}
