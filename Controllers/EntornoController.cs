using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app.Models;


namespace app.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class EntornoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { Environment.GetEnvironmentVariable("uri_desarrollo") };
        }

    }
}
