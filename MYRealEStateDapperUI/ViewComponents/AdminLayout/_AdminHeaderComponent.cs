using Microsoft.AspNetCore.Mvc;

namespace MYRealEStateDapperUI.ViewComponents.AdminLayout
{
    public class _AdminHeaderComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
