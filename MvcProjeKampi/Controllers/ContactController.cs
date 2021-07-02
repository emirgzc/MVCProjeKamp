using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
        MessageManager mm = new MessageManager(new EfMessageDal());
        ContactValidator cv = new ContactValidator();
        [Authorize]
        public ActionResult Index()
        {
            var contactlist = cm.GetList();
            return View(contactlist);
        }
        public ActionResult GetContactDetails(int id)
        {
            var getcontact = cm.GetByID(id);
            return View(getcontact);
        }
        public PartialViewResult ShowInboxDetails()
        {
            var contactList = cm.GetList();
            ViewBag.contactCount = contactList.Count();
            var listResult = mm.GetListSendbox();
            ViewBag.sendCount = listResult.Count();
            var listResult2 = mm.GetListInbox();
            ViewBag.inboxCount = listResult2.Count();
            return PartialView();
        }
    }
}