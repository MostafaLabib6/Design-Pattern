
namespace Singleton;

public class Logger
{
    private static Logger? _instance;

    public static Logger GetInstance
    {
        get
        {
            if (_instance == null)
                _instance = new Logger();
            return _instance;
        }
    }

    public void Log(string message)
    {
        Console.Write($"Message to Log {message}");
    }

}
