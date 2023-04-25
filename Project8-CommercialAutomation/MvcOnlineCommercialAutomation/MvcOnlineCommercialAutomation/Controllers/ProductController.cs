
using MvcOnlineCommercialAutomation.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOnlineCommercialAutomation.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        Context c = new Context();
        public ActionResult Index()
        {
            var values = c.Products.Where(x=> x.Status==true).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddProduct() 
        {
            List<SelectListItem> list = (from x in c.Categories.ToList()
                                         select new SelectListItem 
                                         {
                                             Text=x.CategoryName,
                                             Value=x.CategoryID.ToString()
                                         }).ToList();
            ViewBag.list1=list;                         
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product p)
        {
            c.Products.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteProduct(int id) 
        {
            var value = c.Products.Find(id);
            value.Status = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            List<SelectListItem> list = (from x in c.Categories.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.CategoryName,
                                             Value = x.CategoryID.ToString()
                                         }).ToList();
            ViewBag.list1 = list;
            var value = c.Products.Find(id);
            return View("UpdateProduct", value);
        }
        [HttpPost]
        public ActionResult UpdateProduct(Product p)
        {
            var values = c.Products.Find(p.ProductID);
            values.PurchasePrice = p.PurchasePrice;
            values.Status = p.Status;
            values.CategoryID = p.CategoryID;
            values.Brand=p.Brand;
            values.SalePrice = p.SalePrice;
            values.Stock=p.Stock;
            values.ProductName= p.ProductName;
            values.ProductImage= p.ProductImage;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}