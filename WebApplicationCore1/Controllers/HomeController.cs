using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WebApplicationCore1.Models;

namespace WebApplicationCore1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private AndrewSandboxContext _dbContext;

        private List<Person> _people;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(ILogger<HomeController> logger, AndrewSandboxContext andrewSandboxContext)
        {
            _logger = logger;

            //_dbContext = andrewSandboxContext;

        }

        [HttpGet("")]
        public IActionResult Index()
        {
            //using (_dbContext)
            //{
            //    //var amy = _dbContext.People.Where(x => x.FirstName.ToLower() == "amy").FirstOrDefault();

            //    //if (amy != null)
            //    //{
            //    //    _person = amy;
            //    //}

            //    _people = _dbContext.People.ToList();
            //}

            //return View(_people);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}