using Microsoft.AspNetCore.Mvc;
using PMS.Web.Controllers;

namespace PMS.Web.Public.Controllers
{
    public class HomeController : PMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}