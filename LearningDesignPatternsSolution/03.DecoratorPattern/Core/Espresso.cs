namespace _03.DecoratorPattern.Core
{
    public class Espresso : Beverage
    {
        public override string Description
        {
            get
            {
                return base.Description + ", Espreso";
            }
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}