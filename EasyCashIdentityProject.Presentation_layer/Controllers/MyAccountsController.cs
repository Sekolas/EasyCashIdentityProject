using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.Presentation_layer.Controllers
{
    public class MyAccountsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
