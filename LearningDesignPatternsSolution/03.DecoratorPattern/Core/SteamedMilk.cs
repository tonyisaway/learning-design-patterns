namespace _03.DecoratorPattern.Core
{
    public class SteamedMilk : CondimentDecorator
    {
        private readonly Beverage beverage;

        public SteamedMilk(Beverage beverage)
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
                return this.beverage.Description + ", Steamed Milk";
            }
        }
    }
}