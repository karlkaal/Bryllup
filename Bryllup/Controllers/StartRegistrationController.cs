using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Bryllup.Data;

namespace Bryllup.Controllers
{
    [Route("[controller]/[action]")]
    public class StartRegistrationController : Controller
    {

        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger _logger;

        public StartRegistrationController(SignInManager<ApplicationUser> signInManager, ILogger<AccountController> logger)
        {
            _signInManager = signInManager;
            _logger = logger;
        }


        public IActionResult Get()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}