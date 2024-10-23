using Microsoft.AspNetCore.Mvc;

namespace MYRealEStateDapperUI.ViewComponents.AdminLayout
{
    public class _AdminSidebarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
