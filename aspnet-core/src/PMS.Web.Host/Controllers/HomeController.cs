﻿using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace PMS.Web.Controllers
{
    public class HomeController : PMSControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}
