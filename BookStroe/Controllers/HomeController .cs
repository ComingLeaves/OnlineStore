using BookStroe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       

        
        public ActionResult Stack()
        {
            BookEntities bookEntities = new BookEntities();
            var list = from BookDetails in bookEntities.BookDetails select BookDetails;
            ViewData.Model = list;

            return View();
        }
        public ActionResult StackJingGuan()
        {
            BookEntities bookEntities = new BookEntities();
            var list = from BookDetails in bookEntities.BookDetails select BookDetails;
            ViewData.Model = list;
            return View("Stack - JingGuan");
        }
        public ActionResult StackKeXue()
        {
            BookEntities bookEntities = new BookEntities();
            var list = from BookDetails in bookEntities.BookDetails select BookDetails;
            ViewData.Model = list;
            return View("Stack - KeXue");
        }
        public ActionResult StackRenWen()
        {
            BookEntities bookEntities = new BookEntities();
            var list = from BookDetails in bookEntities.BookDetails select BookDetails;
            ViewData.Model = list;
            return View("Stack - RenWen");
        }
        public ActionResult StackShaoEr()
        {
            BookEntities bookEntities = new BookEntities();
            var list = from BookDetails in bookEntities.BookDetails select BookDetails;
            ViewData.Model = list;
            return View("Stack - ShaoEr");
        }
        public ActionResult StackShengHuo()
        {
            BookEntities bookEntities = new BookEntities();
            var list = from BookDetails in bookEntities.BookDetails select BookDetails;
            ViewData.Model = list;
            return View("Stack - ShengHuo");
        }
        public ActionResult StackWenXue()
        {
            BookEntities bookEntities = new BookEntities();
            var list = from BookDetails in bookEntities.BookDetails select BookDetails;
            ViewData.Model = list;
            return View("Stack - WenXue");
        }
        public ActionResult Book1()
        {

            ViewBag.Message = "Your Book1 page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Your Login page.";

            return View();
        }
        public ActionResult Register()
        {
            ViewBag.Message = "Your Register page.";

            return View();
        }

    }
}