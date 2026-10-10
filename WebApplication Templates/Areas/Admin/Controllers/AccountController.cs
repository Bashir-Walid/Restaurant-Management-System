using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication_Templates.ViewModels;

namespace WebApplication_Templates.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]


    public class AccountController : Controller
    {

        UserManager<IdentityUser> UserManager;
        SignInManager<IdentityUser> SignInManager;

       
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task <IActionResult> Login(LoginViewModels model)
        {
            var user = await UserManager.FindByNameAsync(model.UserName);
            if (user != null)
            {
                var result = await SignInManager.PasswordSignInAsync( user ,model.Password,false,false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Home");

                }
            }
                return View();
        }
        [HttpPost]
        [Authorize]


        public async Task<IActionResult> Logout()
        {
            await SignInManager.SignOutAsync();

            return RedirectToAction(nameof(Login));
        }

        public IActionResult Register()
        { 

            return View();
        }
        [HttpPost]
        [Authorize]

        public async Task<IActionResult> Register(RegisterViewModels model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Password and confirmichen is mathaing");
                return View(model);

            }
            var user = new IdentityUser
            {
                //Email = model.Emil,
                UserName = model.UserName

            };
            var result =await UserManager.CreateAsync(user, model.Password);
            if(result.Succeeded)
            {
                return RedirectToAction(nameof(Login));
            }
            return View();
        }
    }
}
