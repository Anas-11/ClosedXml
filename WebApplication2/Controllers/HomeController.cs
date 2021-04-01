using ClassLibrary2;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IReportManager _reportManager;
        public HomeController(ILogger<HomeController> logger, IReportManager reportManager)
        {
            _logger = logger;
            _reportManager = reportManager;
        }

        public IActionResult Index()
        {
            _reportManager.ExportToExcel();
            return View();
        }

    }
}
