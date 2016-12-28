namespace _02.ObserverPattern.Core.Interfaces
{
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
