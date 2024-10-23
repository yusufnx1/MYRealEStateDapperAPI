using Microsoft.AspNetCore.Mvc;

namespace MYRealEStateDapperUI.ViewComponents.AdminLayout
{
    public class _AdminNavbarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
