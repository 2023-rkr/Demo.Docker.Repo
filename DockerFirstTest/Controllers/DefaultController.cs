using Microsoft.AspNetCore.Mvc;

namespace DockerFirstTest.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class DefaultController : Controller
    {
        private readonly IHostEnvironment _hostEnvironment;

        public DefaultController(IHostEnvironment hostEnvironment)
        {
               _hostEnvironment = hostEnvironment;
        }

        [Route("/")]
        [Route("/docs")]
        [Route("/swagger")]
        public IActionResult Index()
        {
            if (_hostEnvironment.IsDevelopment())
                return new RedirectResult("~/swagger/Index.html");
            return View();
        }
    }
}
