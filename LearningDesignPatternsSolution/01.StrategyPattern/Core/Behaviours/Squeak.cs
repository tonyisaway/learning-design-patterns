namespace _01.StrategyPattern.Core.Behaviours
{
    using Interfaces;
    using System;

    public class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
