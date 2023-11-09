using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pri.Ca.Core.Entities;
using Pri.Ca.Web.ViewModels;

namespace Pri.Ca.Web.Controllers
{
    public class AccountController : Controller
    {
        //inject identity service classes
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController
            (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login([FromQuery] string ReturnUrl)
        {
            var accountLoginViewModel = new AccountLoginViewModel();
            accountLoginViewModel.ReturnUrl = ReturnUrl;
            return View(accountLoginViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(AccountLoginViewModel accountLoginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(accountLoginViewModel);
            }
            var result = await _signInManager.PasswordSignInAsync(accountLoginViewModel.Username,
                accountLoginViewModel.Password, false, false);
            if(!result.Succeeded)
            {
                ModelState.AddModelError("", "Wrong credentials");
                return View(accountLoginViewModel);
            }
            //check for returnUrl
            if(!string.IsNullOrEmpty(accountLoginViewModel.ReturnUrl))
            {
                return Redirect(accountLoginViewModel.ReturnUrl);
            }
            return RedirectToAction("Index","Games");
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(AccountRegisterViewModel accountRegisterViewModel)
        {
            //check modelstate
            if(!ModelState.IsValid)
            {
                return View(accountRegisterViewModel);
            }
            //create user
            var user = new ApplicationUser
            {
                Firstname = accountRegisterViewModel.Firstname,
                Lastname = accountRegisterViewModel.Lastname,
                UserName = accountRegisterViewModel.Username,
                Email = accountRegisterViewModel.Username,
                //only for testing purposes
                EmailConfirmed = true
            };
            //call the CreateAsync method
            var result = await _userManager.CreateAsync(user,accountRegisterViewModel.Password);
            //check the result
            if(!result.Succeeded)
            {
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(accountRegisterViewModel);
            }
            //in production => send confirmation email
            //redirect to welcome page
            return RedirectToAction("Registered");
        }
        [HttpGet]
        public IActionResult Registered()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
