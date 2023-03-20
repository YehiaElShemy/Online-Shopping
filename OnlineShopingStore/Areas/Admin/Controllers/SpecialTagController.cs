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
    public class SpecialTagController : Controller
    {
        private readonly ApplicationDbContext Db;

        public SpecialTagController(ApplicationDbContext db)
        {
            Db = db;
        }
        public IActionResult Index()
        {
            return View(Db.specialTags.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SpecialTag specialTag)
        {
            if (ModelState.IsValid)
            {
                Db.specialTags.Add(specialTag);
                await Db.SaveChangesAsync();
                TempData["Save"] = "SpecialTag Type Created SuccessFully";
                // return RedirectToAction(nameof(Index));
                return RedirectToAction("Index");
            }
            return View(specialTag);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var specialTag = Db.specialTags.Find(id);
            if (specialTag == null)
            {
                return NotFound();
            }
            return View(specialTag);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SpecialTag specialTag)
        {
            if (ModelState.IsValid)
            {
                Db.Update(specialTag);
                await Db.SaveChangesAsync();
                TempData["Edit"] = "Prodcut Type Updated SuccessFully";
                // return RedirectToAction(nameof(Index));
                return RedirectToAction("Index");
            }
            return View(specialTag);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var specialTag = Db.specialTags.Find(id);
            if (specialTag == null)
            {
                return NotFound();
            }
            return View(specialTag);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(SpecialTag specialTag)
        {
            if (ModelState.IsValid)
            {
                // return RedirectToAction(nameof(Index));
                return RedirectToAction("Index");
            }
            return View(specialTag);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var specialTag = Db.specialTags.Find(id);
            if (specialTag == null)
            {
                return NotFound();
            }
            return View(specialTag);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, SpecialTag specialTag)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (id != specialTag.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                Db.Remove(specialTag);
                await Db.SaveChangesAsync();
                TempData["Remove"] = "Prodcut Type deleted SuccessFully";
                // return RedirectToAction(nameof(Index));
                return RedirectToAction("Index");
            }
            return View(specialTag);
        }
    }
}
