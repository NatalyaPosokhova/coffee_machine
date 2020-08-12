using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Beverage coffee = new Coffee();
            Additive milk = new Milk(coffee);
            Additive sugar = new Sugar(milk);
            Additive syrup = new Syrup(sugar);
            Console.WriteLine(syrup.Prepare());

            Beverage tea = new Tea();
            Additive milkAdditive = new Milk(tea);
            Console.WriteLine(milkAdditive.Prepare());

            Console.ReadKey();
        }
    }
}
