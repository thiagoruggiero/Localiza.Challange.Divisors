using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Localiza.Challange.Divisors.Core.Models
{
    public class ResponseDivisors
    {
        public ResponseDivisors()
        {
            AllDivisors = new List<int>();
            PrimeDivisors = new List<int>();
        }

        public List<int> AllDivisors { get; set; }
        public List<int> PrimeDivisors { get; set; }
        [JsonIgnore]
        public bool FoundAnswer { get; set; }
    }
}
