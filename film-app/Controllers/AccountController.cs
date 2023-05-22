using film_app.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace film_app.Controllers
{
    public class AccountController : Controller
    { 
        private UserManager<AppUser> UserMgr { get; }
        private SignInManager<AppUser> SignInMgr { get; }

        public AccountController(UserManager<AppUser> userMgr, SignInManager<AppUser> signInMgr)
        {
            UserMgr = userMgr;
            SignInMgr = signInMgr;
        }

        /*

        public async Task<IActionResult> Register()
        {
            try
            {
                ViewBag.message = "User stworzony";
                AppUser user = await UserMgr.FindByNameAsync("TestUser");

                if (user == null)
                {
                    user = new AppUser()
                    {
                        UserName = "TestUser",
                        Email = "TestUser@test.test",
                        FirstName = "Jan",
                        LastName = "Kowalski"
                    };
                    IdentityResult result = await UserMgr.CreateAsync(user, "Test123!");
                    ViewBag.message = "Stworzono konto!";
                }
            }
            catch(Exception ex)
            {
                ViewBag.message = ex.Message;
            }
            return View();
        }
        */

        [HttpGet]
        public IActionResult Register()
		{
            return View();
		}

        [HttpPost]
        public async Task<IActionResult> Register(AppUser user)
		{
            
            IdentityResult result = await UserMgr.CreateAsync(user, user.Password);
            var errorList = result.Errors.ToList();
            ViewBag.message = string.Join(" ", errorList.Select(e => e.Description));
            return RedirectToAction("Login", "Account");
        }

        [HttpPost]
        public async Task<IActionResult> Login(AppUser user)
		{
            var result = await SignInMgr.PasswordSignInAsync(user.UserName, user.Password, false, false);
            if (result.Succeeded)
			{
                return RedirectToAction("Index", "Home");
			}
			else
			{
                ViewBag.result = "Wynik logowania: " + result.ToString();
			}
            return View();
		}
        


        [HttpGet]
        public async Task<IActionResult> Login()
        {
           
            return View();
        }


        public async Task<IActionResult> Logout()
        {
            await SignInMgr.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
