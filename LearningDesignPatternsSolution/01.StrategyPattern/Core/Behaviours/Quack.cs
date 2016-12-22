namespace _01.StrategyPattern.Core.Behaviours
{
    using Interfaces;
    using System;

    public class Quack : IQuackBehaviour
    {
        void IQuackBehaviour.Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
