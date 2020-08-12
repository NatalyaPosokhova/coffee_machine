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
        public Milk(Beverage beverage) : base(beverage)
        {
        }

        public override string Prepare()
        {
            string result = base.Prepare() + " + Milk";
            return result;
        }
        //public void SetBeverage(Milk milk)
        //{
        //    base.SetBeverage(milk);
        //}
    }
}
