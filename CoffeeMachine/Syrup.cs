using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    /// <summary>
    /// Concrete Decorator Syrup
    /// </summary>
    public class Syrup : Additive
    {
        public Syrup(Beverage beverage) : base(beverage)
        {
        }

        public override string Prepare()
        {
            return base.Prepare() + " + Syrup";
        }
    }
}
