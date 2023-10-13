
namespace AbstractFactory;

/// <summary>
/// Abstract Product 1
/// </summary>
public interface IButtonService
{
    public void print();

}

/// <summary>
/// concrete class 1
/// </summary>
public class WinButton : IButtonService
{
    public void print()
    {
        Console.WriteLine($"Win Button Created! {GetType().Name}");
    }
}

/// <summary>
/// concrete class 2
/// </summary>
public class MacButton : IButtonService
{
    public void print()
    {
        Console.WriteLine($"Mac Button Created! {GetType().Name}");
    }
}


/// <summary>
/// Abstract Product 1
/// </summary>
public interface ICheckBtnService
{
    public void print();
}

/// <summary>
/// concrete class 1
/// </summary>
public class WinCheckBtn : ICheckBtnService
{
    public void print()
    {
        Console.WriteLine($"Win CheckBtn Created! {GetType().Name}");
    }
}

/// <summary>
/// concrete class 2
/// </summary>
public class MacCheckBtn : ICheckBtnService
{
    public void print()
    {
        Console.WriteLine($"Mac CheckBtn Created! {GetType().Name}");
    }
}
/// <summary>
/// Abstract Factory
/// </summary>
public interface IGuiFactory
{
    public IButtonService CreateBtn();
    public ICheckBtnService CreateCheckBtn();
}

/// <summary>
/// concrete Factory 1
/// </summary>
public class WinFactory : IGuiFactory
{
    public IButtonService CreateBtn()
    {
        return new WinButton();
    }

    public ICheckBtnService CreateCheckBtn()
    {
        return new WinCheckBtn();
    }
}
/// <summary>
/// concrete Factory 2
/// </summary>
public class MacFactory : IGuiFactory
{
    public IButtonService CreateBtn()
    {
        return new MacButton();
    }

    public ICheckBtnService CreateCheckBtn()
    {
        return new MacCheckBtn();
    }
}


public class Application
{
    private readonly IGuiFactory _factory;
    
    public Application(IGuiFactory factory)
    {
        this._factory = factory;
    }
    public IButtonService CreateBtn()
    {
        return _factory.CreateBtn();
    }
    public ICheckBtnService CreateCheckBtn()
    {
        return _factory.CreateCheckBtn();
    }
}

