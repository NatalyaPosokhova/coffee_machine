using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    /// <summary>
    /// Concrete component Coffee
    /// </summary>
    public class Coffee : Beverage
    {
        /// <summary>
        /// Prepares Coffee
        /// </summary>
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
