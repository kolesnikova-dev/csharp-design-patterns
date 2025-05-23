public class Program
{
    public static void Main(string[] args)
    {
        WeatherStation weatherStation = new();
        PhoneDisplay phoneDisplay = new();
        DesktopDisplay desktopDisplay = new();
        // Register each display
        weatherStation.RegisterObserver(phoneDisplay);
        weatherStation.RegisterObserver(desktopDisplay);
        // Set temperature to update both displays
        weatherStation.SetTemperature(25.0f);

    }
}