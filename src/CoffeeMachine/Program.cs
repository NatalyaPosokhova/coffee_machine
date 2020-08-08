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
            CoffeeMachine machine = new CoffeeMachine(new Milk(), new Milk(), new Syrup(), new Sugar(), new Sugar());
            Console.WriteLine(machine.PrepareCofee());
            Console.ReadKey();
        }
    }
}
