using Microsoft.AspNetCore.Mvc;

namespace MYRealEStateDapperUI.ViewComponents.AdminLayout
{
    public class _AdminSpinnerComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
