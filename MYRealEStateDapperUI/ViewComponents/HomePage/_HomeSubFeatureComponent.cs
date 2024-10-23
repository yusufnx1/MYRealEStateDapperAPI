using Microsoft.AspNetCore.Mvc;

namespace MYRealEStateDapperUI.ViewComponents.HomePage
{
    public class _HomeSubFeatureComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
