using System.ComponentModel;

namespace Singleton;

public class Program
{
    public void main()
    {
        Logger instance1 = Logger.GetInstance;
        Logger instance2 = Logger.GetInstance;

        if(instance1 == instance2)
            Console.WriteLine("Instances are the same");

    }
}