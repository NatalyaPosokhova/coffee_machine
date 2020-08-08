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
        IAdditive[] _additives;
        /// <summary>
        /// Result means coffee with all additives.
        /// </summary>
        public string Result { get; private set; }

        /// <summary>
        /// All additives are added in the coffee
        /// </summary>
        /// <returns></returns>
        public string PrepareCofee()
        {
            foreach(IAdditive _additive in _additives)
            {
                Result = _additive.Add(Result);
            }
            return Result;
        }

        public CoffeeMachine(params IAdditive [] additives)
        {
            this._additives = additives;
            this.Result = "Prepare Coffee";
        }
    }
}
