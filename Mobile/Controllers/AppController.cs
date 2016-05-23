using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.OptionsModel;
using Mobile.CustomAttributes;
using Mobile.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Mobile.Controllers
{
    [ServiceFilter(typeof(SiteSetting))]
    public class AppController : Controller
    {
        public AppController()
        {
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("Index");
        }

        public IActionResult Login()
        {
            return View("login");
        }

        public IActionResult MyDetails()
        {
            return View("~/Views/User/MyDetails.cshtml");
        }

        public IActionResult Payslips()
        {
            return View("~/Views/User/Payslips.cshtml");
        }

        public IActionResult Holidays()
        {
            return View("~/Views/User/Holidays.cshtml");
        }

        public IActionResult Requests()
        {
            return View("~/Views/User/Requests.cshtml");
        }

        public IActionResult Tasks()
        {
            return View("~/Views/User/Tasks.cshtml");
        }

        public IActionResult MyTeam()
        {
            return View("~/Views/User/Team.cshtml");
        }
    }
}
