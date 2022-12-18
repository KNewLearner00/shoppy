using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoPractice.Models;

namespace RepoPractice.Controllers
{
    public class CategoryController : Controller
    {
        ShoppingCartDBContext db = new ShoppingCartDBContext();
        // GET: Category
        public ActionResult Index()
        {
            var category = db.CategorySet.ToList();
           
            return View(category);
        }
        public ActionResult Browse(string category)
        {
            var cat = db .CategorySet.Include("Product").SingleOrDefault(c=>c.CategoryName== category);
            return View(cat);
        }
        public ActionResult Details(int id) 
        {
            var Item = new ProductModel { ProductName = "Item" + id };
            return View(Item);
        }
    }
}