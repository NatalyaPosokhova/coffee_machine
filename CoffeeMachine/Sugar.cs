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
        public override void Prepare()
        {
            base.Prepare();
        }
    }
}
