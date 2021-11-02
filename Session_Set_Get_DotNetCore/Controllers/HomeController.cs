using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Session_Set_Get_DotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Session_Set_Get_DotNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            User user = new User()
            {
                Id = 1,
                MSISDN = "01760863687"
            };

            HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(user));

            return View();
        }
    }
}
