using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zahir.Models;

namespace zahir.Controllers
{
    public class SiteController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        // GET: Site
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult about()
        {
            return View();
        }
        public ActionResult contact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult contact(ContactList contact)
        {
            db.ContactList.InsertOnSubmit(contact);
            db.SubmitChanges();
            return View();
        }
        public ActionResult works()
        {
            return View();
        }
        public ActionResult workdetal()
        {
            return View();
        }
        public ActionResult blogs()
        {
            return View();
        }
        public ActionResult blogdetal()
        {
            return View();
        }
        public ActionResult error()
        {
            return View();
        }
    }
}