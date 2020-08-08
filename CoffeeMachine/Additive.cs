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

        /// <summary>
        /// Defines the concrete beverage
        /// </summary>
        /// <param name="beverage"></param>
        public void SetBeverage(Beverage beverage)
        {
            this.beverage = beverage;
        }

        /// <summary>
        /// Prepares beverage
        /// </summary>
        public override void Prepare()
        {
            if(beverage != null)
            {
                beverage.Prepare();
            }
        }
    }
}
