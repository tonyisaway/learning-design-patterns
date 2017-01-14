// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="None">
//   none
// </copyright>
// <summary>
//   DECORATOR PATTERN
//   Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace _03.DecoratorPattern
{
    using System;

    using _03.DecoratorPattern.Core;

    class Program
    {
        static void Main(string[] args)
        {
            var beverage = new Espresso();
            Console.WriteLine($"{beverage.Description} £{beverage.Cost()}");

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"{beverage2.Description} £{beverage2.Cost()}");

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine($"{beverage3.Description} £{beverage3.Cost()}");

            Console.ReadLine();
        }
    }
}