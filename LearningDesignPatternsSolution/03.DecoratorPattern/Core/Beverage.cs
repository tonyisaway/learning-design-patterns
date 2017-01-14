namespace _03.DecoratorPattern.Core
{
    using System;

    public abstract class Beverage
    {
        public enum Sizing
        {
            Tall,

            Grande,

            Venti
        }

        public virtual string Description
        {
            get
            {
                return this.GetSizeDescription(this.Size);
            }
        }

        public virtual Sizing Size { get; set; }

        public abstract double Cost();

        public double GetSizeCost(double cost)
        {
            var sizeCost = cost;
            switch (this.Size)
            {
                case Sizing.Tall:
                    sizeCost = (cost / 3) * 2;
                    break;
                case Sizing.Grande:
                    break;
                case Sizing.Venti:
                    sizeCost = (cost / 3) * 4;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            sizeCost = Math.Round(sizeCost, 2);

            return sizeCost;
        }

        private string GetSizeDescription(Sizing size)
        {
            return size.ToString();
        }
    }
}