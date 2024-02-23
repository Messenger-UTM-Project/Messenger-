using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Localization;
using Echo.Data;
using Echo.Resources;

namespace Echo.Controllers
{
    [AllowAnonymous]
    [Route("[controller]")]
    public class TestController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IStringLocalizer<TestController> _localizer;

        public TestController(AppDbContext context, IStringLocalizer<TestController> localizer)
        {
            _context = context;
            _localizer = localizer;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return View();
        }

    }
}
