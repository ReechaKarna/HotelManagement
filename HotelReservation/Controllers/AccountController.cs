using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HotelReservation.Data;
using HotelReservation.Models;
using System;
using System.Net;
using System.Threading.Tasks;



namespace HotelReservation.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        private readonly RoleManager<IdentityRole> _roleManager;

        private readonly ApplicationDbContext context;

        public AccountController(
        Microsoft.AspNetCore.Identity.UserManager<ApplicationUser> userManager,
        SignInManager<ApplicationUser> signInManager,
        ApplicationDbContext _context,
         Microsoft.AspNetCore.Identity.RoleManager<IdentityRole> roleManager
        )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            context = _context;
            _roleManager = roleManager;

        }






     [HttpGet]
        [AllowAnonymous]
        public ActionResult Register()
        {

            var list = new SelectList(context.Roles, "Name", "Name");
            RegisterViewModel model = new RegisterViewModel();
            
           // model.EmployeeList = new SelectList(context.SoftwareUser, "SoftwareUserId", "SoftwareUserName");
           // model.RolesList = list;
            model.applicationDbContext = context;
            return View(model);
        }




        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.UserName, Email = model.UserName };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
              //      await _userManager.AddToRoleAsync(user, model.RoleName);

             //       user.Userid = model.EmployeeId;

                    await _userManager.UpdateAsync(user);

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return RedirectToLocal(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Contact", "Home");
                    }
                }
                AddErrors(result);
            }
            model.applicationDbContext = context;

           
            return View(model);
        }

        private void AddErrors(IdentityResult result)
        {
            throw new NotImplementedException();
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Signin(string returnUrl = null)
        {
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ViewData["ReturnUrl"] = returnUrl;
            if (!String.IsNullOrEmpty(returnUrl))
            {
                return RedirectToAction(returnUrl);
            }


            return View("Signin");
        }

        // POST: /Account/SignIn
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Signin(LoginViewModel model, string returnUrl = null)
        {
           
            if (ModelState.IsValid)
            {
                ViewData["ReturnUrl"] = returnUrl;

                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);

                if (result.Succeeded)
                {

                    return RedirectToAction("Contact", "Home");
                }

                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }
     
            return View(model);
        }


        public async Task<ActionResult> SignOut()
        {
           
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");



        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Lockout()
        {
            return View();
        }
    }
}