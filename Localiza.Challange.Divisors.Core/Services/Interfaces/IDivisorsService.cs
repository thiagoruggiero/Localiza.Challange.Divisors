using Localiza.Challange.Divisors.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Challange.Divisors.Core.Services.Interfaces
{
    public interface IDivisorsService
    {
        ResponseDivisors GetDivisors(int number);
    }
}
