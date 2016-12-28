namespace _02.ObserverPattern.Core
{
    using Interfaces;

    using System.Collections.Generic;

    public class WeatherData : ISubject
    {
        IList<IObserver> observers;
        float temperature;
        float humidity;
        float pressure;

        public WeatherData ()
        {
            observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach(var o in observers)
            {
                o.Update(temperature, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementChanged();
        }
    }
}
