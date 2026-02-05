using Microsoft.AspNetCore.Mvc;

namespace SGBr.API.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
