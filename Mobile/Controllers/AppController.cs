using Microsoft.AspNet.Mvc;
using Mobile.CustomAttributes;


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

        [ServiceFilter(typeof(ValidationService))]
        public IActionResult MyDetails()
        {
            return View("~/Views/User/MyDetails.cshtml");
        }

        [ServiceFilter(typeof(ValidationService))]
        public IActionResult Payslips()
        {
            return View("~/Views/User/Payslips.cshtml");
        }

        [ServiceFilter(typeof(ValidationService))]
        public IActionResult Holidays()
        {
            return View("~/Views/User/Holidays.cshtml");
        }

        [ServiceFilter(typeof(ValidationService))]
        public IActionResult Requests()
        {
            return View("~/Views/User/Requests.cshtml");
        }

        [ServiceFilter(typeof(ValidationService))]
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
