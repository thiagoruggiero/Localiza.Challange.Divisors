using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Challange.Divisors.Core.Models
{
    public class NumberModel
    {
        public NumberModel()
        {
            Divisors = new ResponseDivisors();
        }

        [Required]
        public int Number { get; set; }

        public ResponseDivisors Divisors { get; set; }

    }
}
