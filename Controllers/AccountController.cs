using CoreFirst.Data;
using CoreFirst.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoreFirst.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public AccountController(AppDbContext appDbContext, UserManager<IdentityUser> userManager)
        {
            _appDbContext = appDbContext;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("signup")]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [Route("signup")]
        public async Task<IActionResult> SignUp(SignupUser signupUser)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = signupUser.Username,
                    Email = signupUser.Username
                };
                var result = await _userManager.CreateAsync(user, signupUser.Password);
                if (result.Succeeded)
                {
                    RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Sorry !! Please try again ");
                }
            }
            return View(signupUser);

        }

    }
}
