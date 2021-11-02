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
    public class GetSessionController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                var getSession = JsonConvert.DeserializeObject<User>(HttpContext.Session.GetString("SessionUser"));
                ViewBag.MSISDN = getSession.MSISDN;
            }
            catch(Exception ex)
            {
                //
            }
           
            return View();
        }
    }
}
