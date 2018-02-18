using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tandfuae.Models;

namespace tandfuae.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult M()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ContactUs()
        {
            ViewBag.Message = "Your contact page.";
            ContactUs contactUs = new ContactUs();
            contactUs.CreatdAt = DateTime.Now;
            return View(contactUs);
        }

        [HttpPost]
        public ActionResult ContactUs(ContactUs contactUs)
        {            
            if (ModelState.IsValid)
            {
                using (var ctx = new ContactUsContext())
                {
                    ContactUs con = contactUs;

                    ctx.ContactsUss.Add(con);
                    ctx.SaveChanges();
                }

                ViewBag.Message = "Successfully send the message.";
                return View();
            }
            return View(contactUs);                
        }

        [Authorize]
        public ActionResult SeeContactUs()
        {
            using (var ctx = new ContactUsContext())
            {
                var Contacts= ctx.ContactsUss.ToList();
                return View(Contacts);
            }            
        }


        public ActionResult ourservices()
        {
            ViewBag.Message = "Our services page.";

            return View();
        }        
    }
}