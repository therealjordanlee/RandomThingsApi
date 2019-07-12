using Microsoft.AspNetCore.Mvc;

namespace RandomThingsApi.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
