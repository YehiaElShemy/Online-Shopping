using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineShopingStore.Data;
using OnlineShopingStore.Models;
using OnlineShopingStore.Utilty;
using Sakura.AspNetCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopingStore.Controllers
{
    [Area("Customer")]
 
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext Db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {   
            _logger = logger;
            this.Db = db;
        }

        public IActionResult Index()
        {
            return View(Db.products.Include(p=>p.ProductTypes).Include(p=>p.specialTag).ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = Db.products.Include(p => p.ProductTypes).Include(p => p.specialTag).Where(p => p.Id == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.SpecialType = product.specialTag.SpecialTagType;
            ViewBag.ProductTypeType = product.ProductTypes.Producttype;
            return View(product);
        }
        [HttpPost]
        [ActionName("Details")]
        public IActionResult ProductDetails(int? id)
        {
            List<Products> products = new List<Products>();//store product in cart
            if (id == null)
            { 
                return NotFound();
            }
            var product = Db.products.Include(p => p.ProductTypes).Include(p => p.specialTag).Where(p => p.Id == id).FirstOrDefault();
            //object that will add to cart 
            if (product == null)
            {
                return NotFound();
            }

            products = HttpContext.Session.Get<List<Products>>("products");
            if (products == null)
            {
                products = new List<Products>();
            }
            products.Add(product);
            HttpContext.Session.Set("products", products);
            //ViewBag.SpecialType = product.specialTag.SpecialTagType;
            //ViewBag.ProductTypeType = product.ProductTypes.Producttype;

            return View(product);
        }
        [ActionName("Remove")]
        public IActionResult RemoveToCart(int? id)
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if (products != null)
            {
                var product = products.FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    products.Remove(product);
                    HttpContext.Session.Set("products", products);
                }
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Remove(int? id)
        {
            List<Products> products= HttpContext.Session.Get<List<Products>>("products");
            if (products != null)
            {
                var product = products.FirstOrDefault(p => p.Id == id);
                if(product != null)
                {
                    products.Remove(product);
                    HttpContext.Session.Set("products", products);
                }
            }
            return RedirectToAction("Index");
        }
        public IActionResult Cart()
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if (products == null)
            {
                products = new List<Products>();
            }
            return View(products);
        }
    }
}
