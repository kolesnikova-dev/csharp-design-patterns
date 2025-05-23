// Adapter patter allows incompatible interfaces to work together 
// by wrapping an existing class with a new interface
// This pattern is useful when integrating third-party libraries
// do not match the expected interface
public interface ITarget
{
    void Request();
}

public class Adaptee
{
    public void SpecificRequest()
    {
        Console.WriteLine("Specific request is called.");
    }
}

// Adapter class implements the ITarget interface and contains and instance of the Adaptee class
public class Adapter : ITarget
{
    private Adaptee adaptee;
    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }

    public void Request()
    {
        // Convert the interface of Adaptee to the Target interface
        adaptee.SpecificRequest();
    }
}