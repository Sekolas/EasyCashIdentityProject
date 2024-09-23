using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.Presentation_layer.ViewComponents.Customer
{
    public class _CustomerLayoutScriptPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
