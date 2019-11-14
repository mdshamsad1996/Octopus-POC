using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class MyController : ApiController
    {
        [HttpGet]
        [Route ("api/HelloWorld")]
        public string Get()
        {
            string env = ConfigurationSettings.AppSettings.Get("Env");
            return "Hello World from "+env;
        }

    }
}
