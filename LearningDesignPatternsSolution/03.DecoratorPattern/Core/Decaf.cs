namespace _03.DecoratorPattern.Core
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
        }

        public override string Description => base.Description + ", Decaf";

        public override double Cost()
        {
            return 1.05;
        }
    }
}