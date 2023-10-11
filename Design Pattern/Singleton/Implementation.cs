
namespace Singleton;

/// <summary>
/// Singleton Logger
/// </summary>
public class Logger
{
    private Logger() { }


    /// <summary>
    /// Support for Lazy Initialization which preduce when we intialize 
    /// instace of object when we need not construction
    /// </summary>
    private static Lazy<Logger> instance
                        = new Lazy<Logger>(() => new Logger());

    //private static Logger? _instance;

    /// <summary>
    /// return global instace of object 
    /// </summary>
    public static Logger GetInstance
    {
        get
        {
            // now its thread safe
            return instance.Value;
            //if (_instance == null)
            //    _instance = new Logger();
            //return _instance;
        }
    }
    /// <summary>
    /// Print logger message
    /// </summary>
    /// <param name="message"></param>
    public void Log(string message)
    {
        Console.Write($"Message to Log {message}");
    }

}
