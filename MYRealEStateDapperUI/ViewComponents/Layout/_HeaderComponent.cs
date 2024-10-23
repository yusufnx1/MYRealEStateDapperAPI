using Microsoft.AspNetCore.Mvc;

namespace MYRealEStateDapperUI.ViewComponents.Layout
{
    public class _HeaderComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
