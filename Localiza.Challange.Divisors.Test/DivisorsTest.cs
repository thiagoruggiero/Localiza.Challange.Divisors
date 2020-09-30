using Localiza.Challange.Divisors.Core.Services;
using Localiza.Challange.Divisors.Core.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Localiza.Challange.Divisors.Test
{
    [TestClass]
    public class DivisorsTest
    {
        private readonly IDivisorsService _Divisorservice;

        public DivisorsTest()
        {
            _Divisorservice = new DivisorsService();
        }

        [TestMethod]
        public void Get_Divisors_OK_33()
        {
            const int NUMBER = 33;
            List<int> ALL_Divisors = new List<int>() { 1, 3, 11, 33 };
            List<int> PRIME_Divisors = new List<int>() { 3, 11 };

            var result = _Divisorservice.GetDivisors(NUMBER);
            Assert.IsTrue(IsListsEquals(result.AllDivisors, ALL_Divisors));
            Assert.IsTrue(IsListsEquals(result.PrimeDivisors, PRIME_Divisors));
        }

        [TestMethod]
        public void Get_Divisors_OK_12()
        {
            const int NUMBER = 12;
            List<int> ALL_Divisors = new List<int>() { 1, 2, 3, 4, 6, 12 };
            List<int> PRIME_Divisors = new List<int>() { 2, 3 };

            var result = _Divisorservice.GetDivisors(NUMBER);
            Assert.IsTrue(IsListsEquals(result.AllDivisors, ALL_Divisors));
            Assert.IsTrue(IsListsEquals(result.PrimeDivisors, PRIME_Divisors));
        }

        [TestMethod]
        public void Get_Divisors_InvalidInput_Negative()
        {
            var result = _Divisorservice.GetDivisors(-3);
            Assert.IsTrue(result.AllDivisors.Count == 0);
            Assert.IsTrue(result.PrimeDivisors.Count == 0);
        }

        private bool IsListsEquals(List<int> firstList, List<int> secondList)
        {
            return firstList.All(secondList.Contains) && firstList.Count == secondList.Count;
        }
    }
}
