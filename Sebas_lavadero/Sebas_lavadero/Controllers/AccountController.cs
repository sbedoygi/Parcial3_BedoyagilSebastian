using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sebas_lavadero.DAL.Entities;
using Sebas_lavadero.DAL;
using Sebas_lavadero.Helpers;
using Sebas_lavadero.Enum;

namespace Sebas_lavadero.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserHelper _userHelper;
        private readonly DataBaseContext _context;
        //private readonly IAzureBlobHelper _azureBlobHelper;

        public AccountController(IUserHelper userHelper, DataBaseContext context /*IAzureBlobHelper azureBlobHelper*/)
        {
            _userHelper = userHelper;
            _context = context;
            //_azureBlobHelper = azureBlobHelper;
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(new Models.LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(Models.LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                Microsoft.AspNetCore.Identity.SignInResult result = await _userHelper.LoginAsync(loginViewModel);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError(string.Empty, "Wrong email or password.");
            }
            return View(loginViewModel);
        }

        public async Task<IActionResult> Logout()
        {
            await _userHelper.LogoutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Unauthorized()
        {
            return View();
        }

        public async Task<IActionResult> EditUser()
        {
            User user = await _userHelper.GetUserAsync(User.Identity.Name);

            if (user == null) return NotFound();

            Models.EditUserViewModel editUserViewModel = new()
            {
                Address = user.Address,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber,
                ImageId = user.ImageId,
                Id = Guid.Parse(user.Id),
                Document = user.Document
            };

            return View(editUserViewModel);
        }


       

        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(Models.ChangePasswordViewModel changePasswordViewModel)
        {
            if (ModelState.IsValid)
            {
                if (changePasswordViewModel.OldPassword == changePasswordViewModel.NewPassword)
                {
                    ModelState.AddModelError(string.Empty, "You must enter a different password.");
                    return View(changePasswordViewModel);
                }

                User user = await _userHelper.GetUserAsync(User.Identity.Name);

                if (user != null)
                {
                    IdentityResult result = await _userHelper.ChangePasswordAsync(user, changePasswordViewModel.OldPassword, changePasswordViewModel.NewPassword);
                    if (result.Succeeded) return RedirectToAction("EditUser");
                    else ModelState.AddModelError(string.Empty, result.Errors.FirstOrDefault().Description);
                }
                else ModelState.AddModelError(string.Empty, "User not found.");
            }

            return View(changePasswordViewModel);
        }
    }
}
