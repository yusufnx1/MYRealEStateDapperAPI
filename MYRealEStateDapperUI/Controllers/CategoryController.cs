using Microsoft.AspNetCore.Mvc;

namespace MYRealEStateDapperUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
