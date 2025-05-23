public class Database
{
    private static Database _instance;
    // private constructor
    private Database()
    {
        Console.WriteLine("Database connection established");
    }
    public static Database GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Database();
            return _instance;
        }
        return _instance;
    }
}