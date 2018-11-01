using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app.Models;

namespace app.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "OK" };
        }

    }
}
