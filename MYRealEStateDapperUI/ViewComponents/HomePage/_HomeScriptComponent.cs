using Microsoft.AspNetCore.Mvc;

namespace MYRealEStateDapperUI.ViewComponents.HomePage
{
    public class _HomeScriptComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
