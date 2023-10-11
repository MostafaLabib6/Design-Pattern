// See https://aka.ms/new-console-template for more information
using Singleton;

Console.Title = "Singleton";

Logger instance1 = Logger.GetInstance;
Logger instance2 = Logger.GetInstance;


if (instance1 == instance2)
    Console.WriteLine("Instances are the same");

instance1.Log($"Instance of {nameof(instance1)}\n");
instance2.Log($"Instance of {nameof(instance2)}\n");


//equals hachcode of two instances.
Console.WriteLine(instance1.GetHashCode());
Console.WriteLine(instance2.GetHashCode());
