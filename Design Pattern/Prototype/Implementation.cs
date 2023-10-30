using Newtonsoft.Json;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Prototype;

public interface Person
{
    public string Name { get; set; }
    public Person Clone(bool deepClone);
}

public class Manager : Person
{
    public string Name { get; set; } = string.Empty;
    public Manager(string name)
    {
        Name = name;
    }

    public Person Clone(bool deepClone = false)
    {
        if (deepClone)
        {
            var PersonSerializer = JsonConvert.SerializeObject(this);
            Manager manager = JsonConvert.DeserializeObject<Manager>(PersonSerializer) ?? new Manager("default");
            return manager;
        }
        else
            return (Manager)MemberwiseClone();
    }
    public override string ToString()
    {
        return $"Manger Name {Name}";
    }
}
public class Employee : Person
{
    public string Name { get; set; } = string.Empty;
    public Manager Manager { get; set; }

    public Employee(string name, Manager manager)
    {
        Name = name;
        Manager = manager;
    }

    public Person Clone(bool deepClone = false)
    {
        if (deepClone)
        {
            var PersonSerializer = JsonConvert.SerializeObject(this);
            var employee = JsonConvert.DeserializeObject<Employee>(PersonSerializer);
            return employee!;
        }
        else
            return (Employee)MemberwiseClone();
    }
    public override string ToString()
    {
        return $"Manager Name {Manager.Name} Employee Name {Name}";
    }
}