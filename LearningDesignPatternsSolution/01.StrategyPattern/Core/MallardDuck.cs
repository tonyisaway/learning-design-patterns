namespace _01.StrategyPattern.Core
{
    using System;
    using Behaviours;

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("I'm a mallard duck.");
        }
    }
}
