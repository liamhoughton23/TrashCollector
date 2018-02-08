using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrashWebsite.Models;
using Microsoft.AspNet.Identity;

namespace TrashWebsite.Controllers
{
    public class CustomerPickupsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CustomerPickups
        public ActionResult Index()
        {
            var customerPickups = db.Customer.Include(c => c.Id);
            return View(customerPickups.ToList());
        }

        // GET: CustomerPickups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerPickup customerPickup = db.Customer.Find(id);
            if (customerPickup == null)
            {
                return HttpNotFound();
            }
            return View(customerPickup);
        }

        // GET: CustomerPickups/Create
        public ActionResult Create()
        {
            ViewBag.Id = new SelectList(db.Users, "Id", "FirstName");
            return View();
        }

        // POST: CustomerPickups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PrimaryId,Id,FirstName,LastName,Address,ZipCode,VacationDates,PickUpDay")] CustomerPickup customerPickup)
        {
            if (ModelState.IsValid)
            {
                customerPickup.TableId = User.Identity.GetUserId();
                db.Customer.Add(customerPickup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Id = new SelectList(db.Users, "Id", "FirstName", customerPickup.Id);
            return View(customerPickup);
        }

        // GET: CustomerPickups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerPickup customerPickup = db.Customer.Find(id);
            if (customerPickup == null)
            {
                return HttpNotFound();
            }
            ViewBag.Id = new SelectList(db.Users, "Id", "FirstName", customerPickup.Id);
            return View(customerPickup);
        }

        // POST: CustomerPickups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PrimaryId,Id,Address,ZipCode,VacationDates,PickUpDay")] CustomerPickup customerPickup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerPickup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Id = new SelectList(db.Users, "Id", "FirstName", customerPickup.Id);
            return View("CustomerHome", "CustomerPickups");
        }

        // GET: CustomerPickups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerPickup customerPickup = db.Customer.Find(id);
            if (customerPickup == null)
            {
                return HttpNotFound();
            }
            return View(customerPickup);
        }

        // POST: CustomerPickups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CustomerPickup customerPickup = db.Customer.Find(id);
            db.Customer.Remove(customerPickup);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult CustomerHome()
        {
            return View();
        }
    }
}
