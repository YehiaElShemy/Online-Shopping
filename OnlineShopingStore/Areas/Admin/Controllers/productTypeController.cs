using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShopingStore.Data;
using OnlineShopingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopingStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class productTypeController : Controller
    {
        public productTypeController(ApplicationDbContext db)
        {
            Db = db;
        }

        public ApplicationDbContext Db { get; }

        public IActionResult Index()
        {
            return View(Db.ProductTypes.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductType product)
        {
            if (ModelState.IsValid)
            {
                Db.ProductTypes.Add(product);
                await Db.SaveChangesAsync();
                TempData["Save"] = "Prodcut Type Created SuccessFully";
                // return RedirectToAction(nameof(Index));
                return RedirectToAction("Index");
            }
            return View(product);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var producttype = Db.ProductTypes.Find(id);
            if (producttype == null)
            {
                return NotFound();
            }
            return View(producttype);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductType product)
        {
            if (ModelState.IsValid)
            {
                Db.Update(product);
                await Db.SaveChangesAsync();
                TempData["Edit"] = "Prodcut Type Updated SuccessFully";
                // return RedirectToAction(nameof(Index));
                return RedirectToAction("Index");
            }
            return View(product);
        }
   
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var producttype = Db.ProductTypes.Find(id);
            if (producttype == null)
            {
                return NotFound();
            }
            return View(producttype);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(ProductType product)
        {
            if (ModelState.IsValid)
            {
                // return RedirectToAction(nameof(Index));
                return RedirectToAction("Index");
            }
            return View(product);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var producttype = Db.ProductTypes.Find(id);
            if (producttype == null)
            {
                return NotFound();
            }
            return View(producttype);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id,ProductType product)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (id != product.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                Db.Remove(product);
                await Db.SaveChangesAsync();
                TempData["Remove"] = "Prodcut Type deleted SuccessFully";
                // return RedirectToAction(nameof(Index));
                return RedirectToAction("Index");
            }
            return View(product);
        }
    }
}
