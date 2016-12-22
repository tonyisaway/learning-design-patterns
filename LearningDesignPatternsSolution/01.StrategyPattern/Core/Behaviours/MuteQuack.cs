namespace _01.StrategyPattern.Core.Behaviours
{
    using Interfaces;
    using System;

    public class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
