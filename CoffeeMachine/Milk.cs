using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    /// <summary>
    /// Concrete Decorator Milk
    /// </summary>
    public class Milk : Additive
    {
        public override void Prepare()
        {
            base.Prepare();
        }
    }
}
