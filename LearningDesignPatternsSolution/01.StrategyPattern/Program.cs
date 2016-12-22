// The Strategy Pattern
// ---------------------
// Defines a family of algorithms, encapsulates each one, and makes them interchangable.
// Strategy lets the algorithm vary independently from clients that use it.
// ---------------------

// Favour Composition over in-heritance.

namespace _01.StrategyPattern
{
    using Core;
    using Core.Behaviours;
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("MiniDuckSimulator");

            var mallard = new MallardDuck();
            mallard.display();
            mallard.performFly();
            mallard.performQuack();
            mallard.Swim();
            Console.WriteLine("--");

            var model = new ModelDuck();
            model.display();
            model.performFly();
            model.SetFlyBehaviour(new FlyRocketPowered());
            model.performFly();
            model.Swim();

            Console.ReadLine();
        }
    }
}
