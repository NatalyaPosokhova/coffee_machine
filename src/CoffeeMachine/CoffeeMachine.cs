using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    /// <summary>
    /// Describes Coffee Machine
    /// </summary>
    public class CoffeeMachine
    {
        /// <summary>
        /// Result means coffee with all additives.
        /// </summary>
        public string Result { get; private set; }

        /// <summary>
        /// Additives
        /// </summary>
        private string sugar = "shugar";
        private string syrup = "syrup";
        private string milk = "milk";
        private string add = " + ";

        /// <summary>
        /// All additives arre added in the coffee
        /// </summary>
        /// <param name="additive"></param>
        /// <returns></returns>
        public string PrepareCofee(List<string> additive)
        {
            if (additive.Contains(sugar))
            {
                Result += add + sugar;
            }
            if(additive.Contains(syrup))
            {
                Result += add + syrup;
            }
            if(additive.Contains(milk))
            {
                Result += add + milk;
            }
            return Result;
        }

        public CoffeeMachine()
        {
            this.Result = "Prepare Coffee";
        }
    }
}
