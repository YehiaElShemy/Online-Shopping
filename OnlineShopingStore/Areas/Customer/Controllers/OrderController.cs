using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopingStore.Data;
using OnlineShopingStore.Models;
using Microsoft.AspNetCore.Http;
using OnlineShopingStore.Utilty;

namespace OnlineShopingStore.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext Db;

        public OrderController(ApplicationDbContext db)
        {
            this.Db = db;
        }
        public IActionResult Chechout()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Chechout(Order anOrder )
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if (products != null)
            {
                foreach (var product in products)
                {
                    OrderDetails orderDetails = new OrderDetails();
                    orderDetails.ProductId = product.Id;
                
                    anOrder.OrderDetails.Add(orderDetails);
                //    Db.products.Remove(product); delete from Database

                }
              
                anOrder.OrderNo = GetOrderNo();
                Db.Orders.Add(anOrder);
                await Db.SaveChangesAsync();
                HttpContext.Session.Set("products", new List<Products>());
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public string GetOrderNo()
        {
            int rowCount = Db.Orders.ToList().Count()+1;
            return rowCount.ToString("000");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
