namespace _01.StrategyPattern.Core
{
    using Behaviours;
    using System;

    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new MuteQuack();
        }

        public override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
