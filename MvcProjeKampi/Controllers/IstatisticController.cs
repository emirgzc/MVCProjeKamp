using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class IstatisticController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        Context c = new Context();
        public ActionResult Index()
        {
            var list = c.Categories.Count();
            ViewBag.count = list;

            var cat = c.Headings.Where(x => x.CategoryID == 15).Count();
            ViewBag.headcount = cat;

            var findA = c.Writers.Where(z => z.WriterName.Contains("a")).Count();
            ViewBag.Acount = findA;

            var statusTrue = c.Categories.Where(g => g.CategoryStatus == true).Count();
            var statusFalse = c.Categories.Where(g => g.CategoryStatus == false).Count();
            var fark = statusTrue - statusFalse;
            ViewBag.status = fark;

            var headingUp = c.Categories.Where(u => u.CategoryID == c.Headings.GroupBy(x => x.CategoryID).OrderByDescending(x => x.Count())
                .Select(x => x.Key).FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault();
            ViewBag.head = headingUp;
            return View();
        }
    }
}