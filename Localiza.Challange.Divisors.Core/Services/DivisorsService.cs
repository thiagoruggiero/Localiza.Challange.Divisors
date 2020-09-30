using Localiza.Challange.Divisors.Core.Models;
using Localiza.Challange.Divisors.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Challange.Divisors.Core.Services
{
    public class DivisorsService : IDivisorsService
    {
        public ResponseDivisors GetDivisors(int number)
        {
            var allDivisors = GetAllDivisors(number);

            return new ResponseDivisors()
            {
                AllDivisors = allDivisors,
                PrimeDivisors = GetPrimeNumbers(allDivisors),
                FoundAnswer = allDivisors.Count > 1
            };
        }


        private List<int> GetAllDivisors(int number)
        {
            var result = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        private List<int> GetPrimeNumbers(List<int> numbers)
        {
            var result = new List<int>();

            foreach (var number in numbers)
            {
                if (GetAllDivisors(number).Count == 2)
                {
                    result.Add(number);
                }
            }
            return result;
        }
    }
}
