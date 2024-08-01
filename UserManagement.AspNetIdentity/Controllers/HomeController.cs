using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserManagement.AspNetIdentity.Models;
using UserManagement.AspNetIdentity.Models.ViewModels;

namespace UserManagement.AspNetIdentity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }



     
    }
}
