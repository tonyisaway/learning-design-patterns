namespace _01.StrategyPattern.Core
{
    using Interfaces;

    public abstract class Duck
    {
        protected IFlyBehaviour flyBehaviour;
        protected IQuackBehaviour quackBehaviour;
        
        protected Duck()
        {
        }

        public abstract void display();

        public void SetFlyBehaviour(IFlyBehaviour f)
        {
            flyBehaviour = f;
        }

        public void SetQuackBehaviour(IQuackBehaviour q)
        {
            quackBehaviour = q;
        }


        public void performFly()
        {
            flyBehaviour.Fly();
        }

        public void performQuack()
        {
            quackBehaviour.Quack();
        }

        public void Swim()
        {
            System.Console.WriteLine("All ducks float, even decoys!");
        }
    }
}
