namespace _01.StrategyPattern.Core.Behaviours
{
    using System;
    using Interfaces;

    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I don't fly.");
        }
    }
}
