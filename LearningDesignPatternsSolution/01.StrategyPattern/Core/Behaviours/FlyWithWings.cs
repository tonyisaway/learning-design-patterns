namespace _01.StrategyPattern.Core.Behaviours
{
    using System;
    using Interfaces;

    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with wings!");
        }
    }
}
