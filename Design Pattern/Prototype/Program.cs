

Console.Title = "Prototype";
var manager = new Prototype.Manager("Emad");
var managerClone = manager.Clone();
Console.WriteLine(manager);
Console.WriteLine(managerClone);

var employee = new Prototype.Employee("Mostafa", (Prototype.Manager)managerClone);
var employeeClone = employee.Clone();
Console.WriteLine(employee);
Console.WriteLine(employeeClone);