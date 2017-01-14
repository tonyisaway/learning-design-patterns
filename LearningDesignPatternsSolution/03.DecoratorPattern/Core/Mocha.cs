namespace _03.DecoratorPattern.Core
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return this.GetSizeCost(.20) + this.beverage.Cost();
        }

        public override string Description
        {
            get
            {
                return this.beverage.Description + ", Mocha";
            }
        }
    }
}