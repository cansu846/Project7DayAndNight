using Project7DayAndNight.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace Project7DayAndNight.Controllers
{
    public class ProductController : Controller
    {
        Project7DayAndNightEntities db = new Project7DayAndNightEntities();


        // GET: Product
        [HttpGet]
        public ActionResult ProductList()
        {
            var values = db.Products.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateProduct() {
            return View();  
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            product.ProductStatus = true;
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("ProductList");
        }

        [HttpGet]   
        public ActionResult DeleteProduct(int id)
        {
            var value = db.Products.Find(id);
            db.Products.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id)
        {
            var value = db.Products.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            var value = db.Products.Find(product.ProductId);
            value.ProductPrice = product.ProductPrice; 
            value.ProductStock = product.ProductStock;
            value.ProductName = product.ProductName;
            value.ProductStatus = true;
            db.SaveChanges();
            return RedirectToAction("ProductList");
        }

    }
}