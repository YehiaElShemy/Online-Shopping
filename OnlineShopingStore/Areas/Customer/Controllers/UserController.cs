using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShopingStore.Data;
using OnlineShopingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopingStore.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext Db;
        private readonly SignInManager<IdentityUser> signInManager;

        public UserManager<IdentityUser> UserManager { get; }

        public UserController(UserManager<IdentityUser> userManager,
            ApplicationDbContext db,SignInManager<IdentityUser> signInManager)
        {
            UserManager = userManager;
            this.Db = db;
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            ViewBag.Users = UserManager.Users.ToList();
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ApplicationUser user)
        {
          
            if (ModelState.IsValid)
            {
                IdentityUser identityUser = new IdentityUser();
                identityUser.UserName = user.FristName;// +" "+ user.LastName;
                identityUser.Email = user.UserName;
                // var result = await UserManager.CreateAsync(user);
                var result = await UserManager.CreateAsync(identityUser,user.PasswordHash);
            
                if (result.Succeeded)
                {
                  var isSaved= await UserManager.AddToRoleAsync(identityUser, role:"User");
                    await signInManager.SignInAsync(user, false);
                     TempData["save"] = "User has been created";
                    return RedirectToAction(nameof(Index));
                }
                foreach (var erorr in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, erorr.Description);
                }
            }
            return View();
            
        }
        public IActionResult AddAdmin()
        {
            return View("Create");
        }
        [HttpPost]
        public async Task<IActionResult> AddAdmin(ApplicationUser Admin)
        {

            if (ModelState.IsValid)
            {
                IdentityUser identityUser = new IdentityUser();
                identityUser.UserName = Admin.FristName + " " + Admin.LastName;
                identityUser.Email = Admin.UserName;

                // var result = await UserManager.CreateAsync(user);
                var result = await UserManager.CreateAsync(identityUser, Admin.PasswordHash);

                if (result.Succeeded)
                {
                    var isSaved = await UserManager.AddToRoleAsync(identityUser, role: "Admin");
                    await signInManager.SignInAsync(Admin, false);
                    TempData["save"] = "User has been created";
                    return RedirectToAction(nameof(Index));
                }
                foreach (var erorr in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, erorr.Description);
                }
            }
            return View("Create");

        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var userLogin = await UserManager.FindByNameAsync(login.UserName);
                
                if (userLogin != null)
                {
                    var result = await signInManager.PasswordSignInAsync(userLogin, login.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }

                }
                return View(login);
            }
            return View(login);

        }
        public async Task< IActionResult> Edit(string id)
        {
            var user =await UserManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewBag.UserName = user.UserName;
            ViewBag.Email = user.Email;
            ViewBag.Id = user.Id;
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Edit(string UserName,string Email,string Id)
        {
            if (ModelState.IsValid)
            {
                var userEdit = await UserManager.FindByIdAsync(Id);
                if (userEdit == null)
                {
                    NotFound();
                }
                userEdit.UserName = UserName;
                userEdit.Email = Email;
                var result=await UserManager.UpdateAsync(userEdit);
                if (result.Succeeded)
                {
                    TempData["update"] = "User has been updated";
                    return RedirectToAction(nameof(Index));
                }
                foreach (var erorr in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, erorr.Description);
                }

                RedirectToAction("Index");
            }
            ViewBag.UserName =UserName;
            ViewBag.Email = Email;
            ViewBag.Id = Id;
            return View();
        }
        public async Task<IActionResult> Details(string id)
        {
            var userDetails = await UserManager.FindByIdAsync(id);
            if (userDetails == null)
            {
                return NotFound();
            }
            ViewBag.UserName = userDetails.UserName;
            ViewBag.Email = userDetails.Email;
            ViewBag.Id = userDetails.Id;
            return View();

        }
        public async Task<IActionResult> Locout(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var userLocout = await UserManager.FindByIdAsync(id);
            if (userLocout == null)
            {
                return NotFound();
            }
            ViewBag.UserName = userLocout.UserName;
            ViewBag.Email = userLocout.Email;
            ViewBag.Id = userLocout.Id;
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> Locout(string UserName, string Email, string Id)
        {
            var userInfo = await UserManager.FindByIdAsync(Id);
            if (userInfo==null)
            {
                return NotFound();
            }
            userInfo.LockoutEnd = DateTime.Now.AddYears(100);
            int rowAffect = await Db.SaveChangesAsync();
            if (rowAffect > 0)
            {
                TempData["locout"] = "User has been Lockout";
                return RedirectToAction(nameof(Index));
            }
            ViewBag.UserName = UserName;
            ViewBag.Email = Email;
            ViewBag.Id = Id;
            return View();
        }
        public async Task<IActionResult> Active(string id)
        {
            var userActive = await UserManager.FindByIdAsync(id);
            ViewBag.UserName = userActive.UserName;
            ViewBag.Email = userActive.Email;
            ViewBag.Id = userActive.Id;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Active(string UserName, string Email, string Id)
        {
            if (ModelState.IsValid)
            {
                var userActive = await UserManager.FindByIdAsync(Id);
                if (userActive == null)
                {
                    return NotFound();
                }
                userActive.LockoutEnd=DateTime.Now.AddDays(-1);
                var rowAffect = await Db.SaveChangesAsync();
                if (rowAffect > 0)
                {
                    TempData["Active"] = "User has been Active Successfully";
                    return RedirectToAction(nameof(Index));
                }
                

            }
            ViewBag.UserName = UserName;
            ViewBag.Email = Email;
            ViewBag.Id = Id;
            return View();
        }
        public async Task<IActionResult> Delete(string Id)
        {
            var userDelete = await UserManager.FindByIdAsync(Id);
            if (userDelete == null)
            {
                return NotFound();
            }
            ViewBag.UserName = userDelete.UserName;
            ViewBag.Email = userDelete.Email;
            ViewBag.Id = userDelete.Id;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(string UserName, string Email, string Id)
        {
            if (ModelState.IsValid)
            {
                var userDelete = await UserManager.FindByIdAsync(Id);
                if (userDelete == null)
                {
                    return NotFound();
                }
               // userActive.LockoutEnd = DateTime.Now.AddDays(-1);
               
                await UserManager.DeleteAsync(userDelete);
                 await Db.SaveChangesAsync();
                
                
                  TempData["Active"] = "User has been Active Successfully";
                  return RedirectToAction(nameof(Index));
              


            }
            ViewBag.UserName = UserName;
            ViewBag.Email = Email;
            ViewBag.Id = Id;

            return View();
        }

    }
}
