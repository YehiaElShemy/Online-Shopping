using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineShopingStore.Areas.Admin.Model;
using OnlineShopingStore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopingStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class RoleController : Controller
    {
        private readonly ApplicationDbContext Db;

        public RoleManager<IdentityRole> RoleManager { get; }
        public UserManager<IdentityUser> UserManager { get; }

        public RoleController(RoleManager<IdentityRole> roleManager, ApplicationDbContext db,UserManager<IdentityUser> userManager)
        {
            RoleManager = roleManager;
            this.Db = db;
            UserManager = userManager;
        }



        public IActionResult Index()
        {
            ViewBag.Roles = RoleManager.Roles.ToList();
            return View(ViewBag.Roles);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(string Name)
        {
            IdentityRole role = new IdentityRole();
            role.Name = Name;
            var isExist = await RoleManager.RoleExistsAsync(role.Name);
            if (isExist)
            {
                ViewBag.Name = Name;
                ModelState.AddModelError(string.Empty, "this role is already is found");
                return View();
            }
            var result = await RoleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                TempData["save"] = "Role has been created";
                return RedirectToAction(nameof(Index));
            }
            foreach (var erorr in result.Errors)
            {
                ModelState.AddModelError(string.Empty, erorr.Description);
            }
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Edit(string id)
        {
            var role = await RoleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            ViewBag.Id = role.Id;
            ViewBag.Name = role.Name;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(string id, string Name)
        {

            var roleUpdate = await RoleManager.FindByIdAsync(id);
            if (roleUpdate == null)
            {
                return NotFound();
            }
            roleUpdate.Name = Name;
            var isExist = await RoleManager.RoleExistsAsync(roleUpdate.Name);
            if (isExist)
            {
                ViewBag.Name = Name;
                ModelState.AddModelError(string.Empty, "this role is already is Exist");

                return View();
            }
            var result = await RoleManager.UpdateAsync(roleUpdate);
            if (result.Succeeded)
            {
                TempData["save"] = "Role has been Updated";
                return RedirectToAction(nameof(Index));
            }
            foreach (var erorr in result.Errors)
            {
                ModelState.AddModelError(string.Empty, erorr.Description);
            }
            return View(Name);
        }
        public async Task<IActionResult> Delete(string id)
        {
            var roleDelete = await RoleManager.FindByIdAsync(id);
            if (roleDelete == null)
            {
                return NotFound();
            }
            ViewBag.Id = roleDelete.Id;
            ViewBag.Name = roleDelete.Name;
            return View();
        }
        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(string id)
        {
            var roleDelete = await RoleManager.FindByIdAsync(id);
            if (roleDelete == null)
            {
                return NotFound();
            }
            var result = await RoleManager.DeleteAsync(roleDelete);
            if (result.Succeeded)
            {
                ViewBag.delete = "this Role is Deleted";
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Assign()
        {
            ViewBag.UserId = new SelectList(Db.ApllicationUsers.Where(u => u.LockoutEnd < DateTime.Now || u.LockoutEnd == null).ToList(), "Id", "UserName");
            ViewBag.RoleId = new SelectList(RoleManager.Roles.ToList(), "Name", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Assign(RoleUserVm roleUser)
        {
            var user = Db.ApllicationUsers.FirstOrDefault(u => u.Id == roleUser.UserId);
            var isCheckRoleAssign = await UserManager.IsInRoleAsync(user, roleUser.RoleId);
            if (isCheckRoleAssign)
            {
                ViewBag.mgs = "this user Already Assign this Role";
                ViewBag.UserId = new SelectList(Db.ApllicationUsers.Where(u => u.LockoutEnd < DateTime.Now || u.LockoutEnd == null).ToList(), "Id", "UserName");
                ViewBag.RoleId = new SelectList(RoleManager.Roles.ToList(), "Name", "Name");
                return View();
            }
            var role = await UserManager.AddToRoleAsync(user, roleUser.RoleId);
            if (role.Succeeded)
            {
                TempData["save"] = "User Role Assigned";
                return RedirectToAction("Index");
            }
            return View();

        }
        public IActionResult AssignUserRole()
        {
            var result = from ur in Db.UserRoles
                         join r in Db.Roles on ur.RoleId equals r.Id
                         join a in Db.ApllicationUsers on ur.UserId equals a.Id
                         select new UserRoleMap
                         {
                             UserId = ur.UserId,
                             Username = a.UserName,
                             RoleId = ur.RoleId,
                             RoleName = r.Name

                         };
            ViewBag.UserRole = result;
            return View();
                  
        }
    }
}
 
