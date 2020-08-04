using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNET;
using ASPNET.Models;
using Dapper;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPNET.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewRepository rrepo;
        public ReviewController (IReviewRepository rrepo)
        {
            this.rrepo = rrepo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var reviews = rrepo.GetAllReviews();
            return View(reviews);
        }

        public IActionResult ViewReview(int id)
        {
            var review = rrepo.GetReview(id);
            return View(review);
        }
        public IActionResult UpdateReview(int id)
        {
            Review revi = rrepo.GetReview(id);

            rrepo.UpdateReview(revi);

            if (revi == null)
            {
                return View("ReviewNotFound");
            }
            return View(revi);
        }
        public IActionResult UpdateReviewToDatabase(Review review)
        {
            rrepo.UpdateReview(review);

            return RedirectToAction("ViewReview", new { id = review.ReviewID });
        }
        public IActionResult InsertReview()
        {
            var revi = rrepo.AssignCategory();

            return View(revi);
        }
        public IActionResult InsertReviewToDatabase(Review reviewToInsert)
        {
            rrepo.InsertReview(reviewToInsert);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteReview(Review review)
        {
            rrepo.DeleteReview(review);

            return RedirectToAction("Index");
        }

    }
}
