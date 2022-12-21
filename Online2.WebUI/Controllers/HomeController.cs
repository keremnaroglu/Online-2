using Microsoft.AspNetCore.Mvc;
using Online2.BLL.Abstract;
using Online2.Entity;
using Online2.Syst;
using Online2.ViewModels.UserViewModels;
using Online2.WebUI.Models;
using System.Diagnostics;

namespace Online2.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserBLL _userBLL;

        public HomeController(ILogger<HomeController> logger, IUserBLL userBLL)
        {
            _logger = logger;
            _userBLL = userBLL;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginVM vm)
        {

            ResultService<User> user = _userBLL.Login(vm);

            if (user.HasError)
            {
                string errorMessage = user.ErrorItems.ToList()[0].ErrorMessage;
                string errorType = user.ErrorItems.ToList()[0].ErrorType;

                ViewData["ErrorMessage"] = errorMessage;
                ViewData["ErrorType"] = errorType;

                return View(vm);
            }

            string baseUrl = "https://localhost:7223";

            if (user.Data.UserTypes == UserTypes.Admin)
            {
                return Redirect($"{baseUrl}/Admin/Home/Index/{user.Data.Id}");
            }
            else
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}