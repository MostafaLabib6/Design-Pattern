using System.Drawing;
using System.Text;

namespace Builder;
public class Burger
{
    private List<string> ingradiants = new List<string>();
    private readonly string BurgerType = string.Empty;

    public Burger(string type)
    {
        BurgerType = type;
    }
    public void addIngrediants(string ing)
    {
        ingradiants.Add(ing);
    }
    public override string ToString()
    {
        var st = new StringBuilder();
        st.Append($"Burger Type: {BurgerType}\nIngrediants [");
        foreach (string ing in ingradiants)
        {
            st.Append(ing+"  ");
        }
        st.Append(']');
        return st.ToString();
    }


}



/// <summary>
/// Builder
/// </summary>
public abstract class IBurgerBuilder
{
    public Burger _burger { get; }
    public abstract Burger addBeff();
    public abstract Burger addCheese();
    public abstract Burger addOnion();

    public IBurgerBuilder(string type)
    {
        _burger = new Burger(type);
    }

}

public class WorldWarBurger : IBurgerBuilder
{

    public WorldWarBurger() : base("WorldWar")
    {
    }
    public override Burger addBeff()
    {
        _burger.addIngrediants("2 Beff");
        return _burger;
    }

    public override Burger addCheese()
    {
        _burger.addIngrediants("2 motzarila Chesse");
        return _burger;
    }

    public override Burger addOnion()
    {
        _burger.addIngrediants("1 Onion ");
        return _burger;
    }
}

public class OriginalBurger : IBurgerBuilder
{

    public OriginalBurger() : base("WorldWar")
    {
    }
    public override Burger addBeff()
    {
        _burger.addIngrediants("1 Beff");
        return _burger;
    }

    public override Burger addCheese()
    {
        _burger.addIngrediants("2 Chesse");
        return _burger;
    }

    public override Burger addOnion()
    {
        // didn't contains onion
        return _burger;
    }
}


/// <summary>
/// director
/// </summary>
public class Casher
{
    private IBurgerBuilder? _builder;
    public IBurgerBuilder Constract(IBurgerBuilder builder)
    {
        _builder = builder;

        _builder.addBeff();
        _builder.addCheese();
        _builder.addOnion();

        return _builder;
    }
}