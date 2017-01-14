namespace _03.DecoratorPattern.Core
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
        }

        public override string Description => base.Description + ", Dark Roast";

        public override double Cost()
        {
            return .99;
        }
    }
}