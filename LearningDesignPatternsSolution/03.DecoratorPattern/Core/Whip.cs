namespace _03.DecoratorPattern.Core
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return this.GetSizeCost(.10) + this.beverage.Cost();
        }

        public override string Description
        {
            get
            {
                return this.beverage.Description + ", Whip";
            }
        }
    }
}