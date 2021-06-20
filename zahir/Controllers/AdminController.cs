using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using zahir.Models;

namespace zahir.Controllers
{
    public class AdminController : Controller
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        // GET: Admin
        public ActionResult AdminContact()
        {
            List<ContactList> contactlist = new List<ContactList>();
            contactlist = db.ContactList.ToList();
            return View(contactlist);
        }
        public ActionResult DeleteContact(int id)
        {
            db.ContactList.DeleteOnSubmit(db.ContactList.SingleOrDefault(x => x.UserId == id));
            db.SubmitChanges();
            return RedirectToAction("AdminContact");
        }
        public ActionResult EditContact(int id)
        {
            var contactlist = db.ContactList.Where(s => s.UserId == id).FirstOrDefault();
            return View(contactlist);
        }
        public ActionResult updatecontact(int id, ContactList contact)
        {
            ContactList contactnew = db.ContactList.SingleOrDefault(s => s.UserId == id);
            contactnew.UserName = contact.UserName;
            contactnew.UserSurname = contact.UserSurname;
            contactnew.UserEmail = contact.UserEmail;
            contactnew.UserPhone = contact.UserPhone;
            contactnew.UserMessage = contact.UserMessage;
            db.SubmitChanges();
            return RedirectToAction("AdminContact");
        }

    }
}