using Microsoft.AspNetCore.Mvc;

namespace SiteDeRol.Controllers
{
    public class MembroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
