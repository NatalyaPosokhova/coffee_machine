using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    /// <summary>
    /// Concrete Decorator Sugar
    /// </summary>
    public class Sugar : Additive
    {
        public Sugar(Beverage beverage) : base(beverage)
        {
        }

        public override string Prepare()
        {
            string result = base.Prepare() + " + Sugar";
            return result;
        }
    }
}
