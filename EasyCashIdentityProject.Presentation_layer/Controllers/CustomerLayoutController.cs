using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.Presentation_layer.Controllers
{
	public class CustomerLayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
