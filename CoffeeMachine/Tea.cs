using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    /// <summary>
    /// Concrete Сomponent Tea
    /// </summary>
    public class Tea : Beverage
    {
        /// <summary>
        /// Prepares Tea
        /// </summary>
        public override string Prepare()
        {
            return "Tea";
        }
    }
}
