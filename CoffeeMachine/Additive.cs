using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    /// <summary>
    /// Decorator. Additives to beverages
    /// </summary>
    public abstract class Additive : Beverage
    {
        protected Beverage beverage;

        public Additive(Beverage beverage)
        {
            this.beverage = beverage;
        }

        /// <summary>
        /// Prepares beverage
        /// </summary>
        public override string Prepare()
        {
            if(beverage != null)
            {
                return beverage.Prepare();
            }
            return String.Empty;
        }
    }
}
