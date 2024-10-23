using Microsoft.AspNetCore.Mvc;

namespace MYRealEStateDapperUI.ViewComponents.HomePage
{
    public class _HomeFeatureComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
