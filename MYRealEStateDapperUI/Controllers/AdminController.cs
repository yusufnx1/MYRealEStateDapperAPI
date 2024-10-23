using Microsoft.AspNetCore.Mvc;

namespace MYRealEStateDapperUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
