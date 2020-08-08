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
        public override void Prepare()
        {
            base.Prepare();
        }
    }
}
