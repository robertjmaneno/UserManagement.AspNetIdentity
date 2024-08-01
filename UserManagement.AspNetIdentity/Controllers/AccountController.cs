using Microsoft.AspNetCore.Mvc;
using UserManagement.AspNetIdentity.Models.ViewModels;

namespace UserManagement.AspNetIdentity.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Register()
        {

            RegisterViewModel registerViewModel = new RegisterViewModel();

            return View();
        }
    }
}
