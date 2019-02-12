using Microsoft.AspNetCore.Mvc;
using PMS.Web.Controllers;

namespace PMS.Web.Public.Controllers
{
    public class AboutController : PMSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}