using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.Presentation_layer.ViewComponents.Customer
{
    public class _CustomerLayoutSidebarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
