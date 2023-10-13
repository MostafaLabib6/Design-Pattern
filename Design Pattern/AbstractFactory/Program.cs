using AbstractFactory;

Console.Title = "Abstract Factory";

IEnumerable<IGuiFactory> guiFactories = new List<IGuiFactory>()
{
    new WinFactory(),
    new MacFactory(),
};

foreach (var guiFactory in guiFactories)
{
    IButtonService buttonService = new Application(guiFactory).CreateBtn();
    ICheckBtnService checkBtnService = new Application(guiFactory).CreateCheckBtn();

    buttonService.print();
    checkBtnService.print();
}
