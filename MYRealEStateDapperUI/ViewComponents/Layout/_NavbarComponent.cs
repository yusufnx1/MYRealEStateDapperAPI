using Microsoft.AspNetCore.Mvc;

namespace MYRealEStateDapperUI.ViewComponents.Layout
{
    public class _NavbarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
