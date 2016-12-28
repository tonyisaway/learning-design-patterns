// The Observer Pattern
// ---------------------
// Defines a one-to-many dependency between objects so that when one changes state,
// all of it's dependents are notified and updated automatically.
// ---------------------

// Strive for loosely coupled designs between objects that interact.

namespace _02.ObserverPattern
{
    using Core;
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();

            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);

            weatherData.SetMeasurements(82, 70, 29.2f);

            weatherData.SetMeasurements(78, 90, 29.2f);

            Console.ReadLine();
        }
    }
}
