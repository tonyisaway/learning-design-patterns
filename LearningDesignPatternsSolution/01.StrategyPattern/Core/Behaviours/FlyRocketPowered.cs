namespace _01.StrategyPattern.Core.Behaviours
{
    using Interfaces;
    using System;

    public class FlyRocketPowered : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with rocket power!");
        }
    }
}
