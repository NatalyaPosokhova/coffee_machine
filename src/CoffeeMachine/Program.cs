﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CoffeeMachine machine = new CoffeeMachine();
            Console.WriteLine(machine.PrepareCofee(new List<string> { "milk", "shugar", "syrup" }));
            Console.ReadKey();
        }
    }
}