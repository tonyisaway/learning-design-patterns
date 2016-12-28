using _02.ObserverPattern.Core.Interfaces;

namespace _02.ObserverPattern.Core
{
    using Interfaces;

    using System;

    public class DisplayElementBase : IObserver, IDisplayElement
    {
        ISubject weatherData;

        float temperature;
        float humidity;
        float pressure;

        public DisplayElementBase(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public virtual void Display()
        {
            Console.WriteLine(string.Format("{0}F degrees, {1}% humidity and {2}Bar pressure.", 
                    temperature, 
                    humidity, 
                    pressure));
        }

        public virtual void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }
    }
}
