using Microsoft.AspNetCore.Mvc;

namespace MYRealEStateDapperUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
