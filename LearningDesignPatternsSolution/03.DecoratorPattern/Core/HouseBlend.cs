namespace _03.DecoratorPattern.Core
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
        }

        public override string Description => base.Description + ", HouseBlend";

        public override double Cost()
        {
            return .89;
        }
    }
}