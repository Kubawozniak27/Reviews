using projektKompo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projektKompo.Controllers
{
    public class RattingReviewsController : BaseController
    {
        // GET: RattingReviews
        public ActionResult Index([Bind(Prefix = "Id")] int reviewId)
        {
            var review = _db.Reviews.Find(reviewId);
            if (review != null)
            {
                return View(review);
            }
            return HttpNotFound();
        }
        [Authorize] 
        public ActionResult Create(int reviewId)
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public ActionResult Create(RattingReview model)
        {
            if (ModelState.IsValid)
            {
                model.Author = User.Identity.Name;

                _db.RattingReviews.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = model.ReviewId });
            }
            return View(model);
        }
        [Authorize]
        public ActionResult Edit(int id)
        {

            var review = _db.RattingReviews.Find(id);
            if (review != null)
            {
                return View(review);
            }
            return RedirectToAction("Index", "Reviews");
        }
        [HttpPost]
        [Authorize]
        public ActionResult Edit( RattingReview model)
        {

            if (ModelState.IsValid)
            {
                model.Author = User.Identity.Name;
                _db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index", new { id = model.ReviewId });
            }

            return View(model);
        }
    }
}