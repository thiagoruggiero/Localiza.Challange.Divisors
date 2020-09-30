using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Localiza.Challange.Divisors.Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Localiza.Challange.Divisors.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisorsController : ControllerBase
    {
        private readonly IDivisorsService _DivisorsService;

        public DivisorsController(IDivisorsService DivisorsService)
        {
            _DivisorsService = DivisorsService;
        }

        /// <summary>
        /// Endpoint criado para reutilização de outras aplicações
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Retorna lista de divisores e lista de  divisores primos</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult GetDivisors([FromQuery] int number)
        {
            var responseDivisors = _DivisorsService.GetDivisors(number);

            if (responseDivisors.FoundAnswer)
                return Ok(responseDivisors);
            else
                return NoContent();
        }
    }
}
