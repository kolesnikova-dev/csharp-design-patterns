public interface INotification
{
    void Send(string message);
}
// Each of the derived classes has the required method
public class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Sending Email: " + message);
    }
}

public class SMSNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }
}

public class NotificationFactory
{
    public INotification CreateNotification(string channel)
    {
        if (channel == "Email")
        {
            return new EmailNotification();
        }
        else if (channel == "SMS")
        {
            return new SMSNotification();
        }  
        throw new ArgumentException($"Unsupported notification channel: {channel}");
    }
}