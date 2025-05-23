// Observer pattern
// One object notifies other objects about changes
// Userful for event notifications
// Example: User interface changes when data changes

public interface IObserver
{
    void Update(float temperature);
}

// Subject class - manages a list of IObserver instances and is responsible for notifying
// all registered observers whenever there is a change in its internal state, like a temperature update

public class WeatherStation
{
    private List<IObserver> observers = new List<IObserver>();
    private float temperature;
    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }
    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }
    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature);
        }
    }

    public void SetTemperature(float newTemperature)
    {
        temperature = newTemperature;
        NotifyObservers();
    }
}

// Concrete public derived class 
public class PhoneDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine("Phone display: Temperature updated to " + temperature + " degrees.");
    }
}

public class DesktopDisplay : IObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine("Desktop display: Temperature updated to " + temperature + " degrees.");
    }
}