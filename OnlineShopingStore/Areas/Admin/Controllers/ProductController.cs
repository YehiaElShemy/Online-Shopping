using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using OnlineShopingStore.Data;
using OnlineShopingStore.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace OnlineShopingStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext Db;
        private readonly IWebHostEnvironment webHostEnvironment;


        public ProductController(ApplicationDbContext db, IWebHostEnvironment _webHostEnvironment)
        {
            Db = db;
            webHostEnvironment = _webHostEnvironment;
        }
        public IActionResult Index()
        {
            var listOfProduct = Db.products.Include(p => p.specialTag).Include(p => p.ProductTypes).ToList();
            return View(listOfProduct);
        }
        [HttpPost]
        public IActionResult Index(decimal? LowAmount, decimal? hightAmount ,string Name )
        {
            var listofProduct = Db.products.Include(p => p.ProductTypes).Include(p => p.specialTag)
                .Where(p => p.Name.Contains(Name)).ToList();
           // ViewBag.Name = listofProduct;
            //var productsName = listofProduct.Where(p => p.Name.Contains(Name));

            //var product = Db.products.Include(p => p.ProductTypes).Include(p => p.specialTag)
            //    .Where(p => p.Price >= LowAmount && p.Price <= hightAmount).ToList();
            return View(listofProduct);
            
            //if (LowAmount == null || hightAmount == null)
            //{
            //    return View(product);
            //}

        }
        public IActionResult Create()
        {
            ViewBag.ProductTypeID = new SelectList(Db.ProductTypes.ToList(), "Id", "Producttype");
            ViewBag.SepcialTagID = new SelectList(Db.specialTags.ToList(), "Id", "SpecialTagType");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Products product, IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                var NameProductExits = Db.products.Where(p => p.Name == product.Name).FirstOrDefault();
                if (NameProductExits!=null)
                {
                    ViewBag.Message = "Product Name Already Exit";
                    ModelState.AddModelError(string.Empty, "Product Name Already Exit");
                    return View(product);
                }
                if (Image != null)
                {
                    var uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Images");
                    //var uniqueFileName = Guid.NewGuid().ToString() + "_" + Image.FileName;
                    var ImageName = Image.FileName;
                    string filePath = Path.Combine(uploadsFolder, ImageName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        Image.CopyTo(fileStream);
                    }
                    //await Image.CopyToAsync(new FileStream(ImagePath,FileMode.Create));
                    product.Image = ImageName;
                }
                if (Image == null)
                {
                    product.Image = "~/wwwroot/Images/images.png";
                }

                Db.products.Add(product);
                await Db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(product);
        }
        public IActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var ProductEdit = Db.products.Include(p => p.ProductTypes).
                Include(p => p.specialTag).FirstOrDefault(p => p.Id == Id);
            if (ProductEdit == null)
            {
                return NotFound();
            }

            ViewBag.ProductTypeID = new SelectList(Db.ProductTypes.ToList(), "Id", "Producttype");
            ViewBag.SepcialTagID = new SelectList(Db.specialTags.ToList(), "Id", "SpecialTagType");
            return View(ProductEdit);

          }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Products products,IFormFile Image)
        {
            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                    var uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Images");
                    //var uniqueFileName = Guid.NewGuid().ToString() + "_" + Image.FileName;
                    var ImageName = Image.FileName;
                    string filePath = Path.Combine(uploadsFolder, ImageName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        Image.CopyTo(fileStream);
                    }
                    //await Image.CopyToAsync(new FileStream(ImagePath,FileMode.Create));
                    products.Image = ImageName;
                }
                if (Image == null)
                {
                    products.Image = "~/wwwroot/Images/images.png";
                }
                var productEdit = Db.products.Include(p => p.ProductTypes)
                    .Include(p => p.specialTag).FirstOrDefault(p => p.Id == products.Id);
                if (productEdit == null)
                {
                    return NotFound();
                }
                productEdit.Name = products.Name;
                productEdit.Price = products.Price;
                productEdit.Image = products.Image;
                productEdit.ProductColor = products.ProductColor;
                productEdit.ProductTypeId = products.ProductTypeId;
                productEdit.SpecialTagId = products.SpecialTagId;
                productEdit.IsAvailable = products.IsAvailable;
                Db.products.Update(productEdit);
                await Db.SaveChangesAsync();
                return RedirectToAction("Index");

            }
            return View(products);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ProductDetails = Db.products.Include(p => p.ProductTypes).
                Include(p => p.specialTag).FirstOrDefault(p => p.Id == id);
            if (ProductDetails == null)
            {
                return NotFound();
            }
            ViewBag.SpecialType = ProductDetails.specialTag.SpecialTagType;
            ViewBag.ProductTypeType = ProductDetails.ProductTypes.Producttype;
            ViewBag.ProductTypeID = new SelectList(Db.ProductTypes.ToList(), "Id", "Producttype");
            ViewBag.SepcialTagID = new SelectList(Db.specialTags.ToList(), "Id", "SpecialTagType");
            return View(ProductDetails);


        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ProductDelete = Db.products.Include(p => p.ProductTypes).
                Include(p => p.specialTag).FirstOrDefault(p => p.Id == id);
            if (ProductDelete == null)
            {
                return NotFound();
            }
            ViewBag.SpecialType = ProductDelete.specialTag.SpecialTagType;
            ViewBag.ProductTypeType = ProductDelete.ProductTypes.Producttype;
           
            return View(ProductDelete);


        }
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int? id,Products productsDeleted)
        {

            if (id == null)
            {
                return NotFound();
            }
            if (id != productsDeleted.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                Db.products.Remove(productsDeleted);
               await Db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(productsDeleted);


        }

    } 
}
