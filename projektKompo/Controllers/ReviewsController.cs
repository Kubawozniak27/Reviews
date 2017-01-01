using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using projektKompo.Models;
using projektKompo.ViewModels;

namespace projektKompo.Controllers
{
    public class ReviewsController : BaseController
    {
        

        // GET: Reviews
        public ActionResult Index(int? categoryId = null)
        {
            IEnumerable<Review> reviews;
            if (categoryId.HasValue)
            {
                if (_db.Categories.Any(c => c.Id == categoryId.Value))
                { 
                    reviews = _db.Reviews.Where(p => p.CategoryId == categoryId.Value);
                    return View(reviews);
                }
            }
            reviews = _db.Reviews;
            return View(reviews);
        }

        // GET: Reviews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review =_db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // GET: Reviews/Create
        [Authorize]
        public ActionResult Create()
        {
            var model = new CreateReviewViewModel();
            model.Categories = _db.Categories.Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() });

            return View(model);
        }

        // POST: Reviews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "Id,Tittle,Description,CategoryId")] Review review)
        {
            if (ModelState.IsValid)
            {
                review.Author = User.Identity.Name;
               _db.Reviews.Add(review);
               _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(review);
        }

        // GET: Reviews/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review =_db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // POST: Reviews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "Id,Tittle,Description")] Review review)
        {
            if (ModelState.IsValid)
            {
               _db.Entry(review).State = EntityState.Modified;
               _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(review);
        }

        // GET: Reviews/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Review review =_db.Reviews.Find(id);
            if (review == null)
            {
                return HttpNotFound();
            }
            return View(review);
        }

        // POST: Reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {
            Review review =_db.Reviews.Find(id);
           _db.Reviews.Remove(review);
           _db.SaveChanges();
            return RedirectToAction("Index");
        }

        
    }
}
