namespace _03.DecoratorPattern.Core
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return this.GetSizeCost(.15) + this.beverage.Cost();
        }

        public override string Description
        {
            get
            {
                return this.beverage.Description + ", Soy";
            }
        }
    }
}