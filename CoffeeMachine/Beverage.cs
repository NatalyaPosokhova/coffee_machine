using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    /// <summary>
    /// Component. Abstract beverage, all types of beverages should inherit this class
    /// </summary>
    public abstract class Beverage
    {
        /// <summary>
        /// Prepares beverage
        /// </summary>
        public abstract void Prepare();
    }
}
