namespace _02.ObserverPattern.Core
{
    using System;
    using Interfaces;

    public class CurrentConditionsDisplay : DisplayElementBase
    {
        ISubject weatherData;

        float temperature;
        float humidity;
        float pressure;

        public CurrentConditionsDisplay(ISubject weatherData) : base(weatherData)
        {
        }

        public override void Display()
        {
            Console.WriteLine(string.Format("Current conditions: {0}F degrees, {1}% humidity and {2}Bar pressure.",
                   temperature,
                   humidity,
                   pressure));
        }
    }
}
