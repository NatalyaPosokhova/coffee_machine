using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Syrup : IAdditive
    {
        public string Add(string result)
        {
            return result += " + Syrup";
        }
    }
}
