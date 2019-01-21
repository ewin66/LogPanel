using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using UseAuthorization.Models;

namespace UseAuthorization.Controllers
{
    public class HomeController : Controller
    {
        readonly IConfiguration _conf;
        public HomeController(IConfiguration conf)
        {
            _conf = conf;
        }

        public IActionResult Index()
        {
            _conf["LogDashboard"] = "lock";
            return View();
        }

        public IActionResult Privacy()
        {
            _conf["LogDashboard"] = "open";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
