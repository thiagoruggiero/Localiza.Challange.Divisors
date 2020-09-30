using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Localiza.Challange.Divisors.Core.Models;
using Localiza.Challange.Divisors.Core.Services.Interfaces;

namespace Localiza.Challange.Divisors.Core.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDivisorsService _DivisorsService;

        public HomeController(IDivisorsService DivisorsService)
        {
            _DivisorsService = DivisorsService;
        }

        public IActionResult Index()
        {
            return View(new NumberModel());
        }

        public IActionResult Privacy()
        {
            return View(new NumberModel());
        }

        public IActionResult Calculate(int number)
        {
            var Divisors = _DivisorsService.GetDivisors(number);
            return View("Index", new NumberModel() { Divisors = new ResponseDivisors() { AllDivisors = Divisors.AllDivisors, PrimeDivisors = Divisors.PrimeDivisors } });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
