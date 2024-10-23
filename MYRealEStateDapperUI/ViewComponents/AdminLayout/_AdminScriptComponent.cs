using Microsoft.AspNetCore.Mvc;

namespace MYRealEStateDapperUI.ViewComponents.AdminLayout
{
    public class _AdminScriptComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
