using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TrashWebsite.Models;

namespace TrashWebsite.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        ApplicationDbContext context = new ApplicationDbContext();
        private ApplicationUserManager _userManager;


        public ActionResult CustomerHome()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditInfo()
        {
            string userId = User.Identity.GetUserId();
            CustomerPickup model = new CustomerPickup();
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> EditInfo(CustomerPickup model)
        {
            if (ModelState.IsValid)
            {
                var userid = User.Identity.GetUserId();

                //user.Address = model.Address;
                //user.ZipCode = model.ZipCode;
                //user.VacationDates = model.VacationDates;
               // user.PickUpDates = model.PickUpDay;
                context.SaveChanges();
                return RedirectToAction("CustomerHome", "Customer");
            }
            return RedirectToAction("CustomerHome", "Customer");
        }
    }
}