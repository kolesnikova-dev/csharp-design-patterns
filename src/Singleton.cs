public class Database
{
    // The private constructor prevents external instantiation,
    // while the static method provides a controlled access point to the single instance
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