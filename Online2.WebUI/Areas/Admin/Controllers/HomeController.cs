using Microsoft.AspNetCore.Mvc;
using Online2.BLL.Abstract;

namespace Online2.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly IUserBLL _userBLL;

        public HomeController(IUserBLL userBLL)
        {
            _userBLL = userBLL;
        }

        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
