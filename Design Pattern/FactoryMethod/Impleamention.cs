using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod;
/// <summary>
/// Product 
/// </summary>
public interface IDiscountService
{
    public int DiscountPercentage { get; }
}

/// <summary>
/// Concrate Product 1
/// Class that provide impleamention for Product Interface
/// </summary>
public class CodeDiscountService : IDiscountService
{
    private readonly Guid _code;
    public CodeDiscountService(Guid code)
    {
        _code = code;
    }
    // each code returns the same fixed percentage, but a code is only 
    // valid once - include a check to so whether the code's been used before
    public int DiscountPercentage => 16;
}

/// <summary>
/// Concrate Product 2
/// Class that provide impleamention for Product Interface
/// </summary>
public class CountryDiscountService : IDiscountService
{
    private readonly string _countryName;

    public CountryDiscountService(string countryName)
    {
        _countryName = countryName;
    }
    public int DiscountPercentage => (_countryName == "EGY") ? 20 : 10;
}

/// <summary>
/// Factory 
/// </summary>
public abstract class DiscountFactory
{
    public abstract IDiscountService GetDiscount();

    public override string? ToString()
        => $"Discount Type {GetType().Name} and discount amount = {GetDiscount().DiscountPercentage}";

}

/// <summary>
/// Concrate Factory 1
/// </summary>
public class CodeDiscountFactory : DiscountFactory
{
    private readonly Guid _code;

    public CodeDiscountFactory(Guid code)
    {
        _code = code;
    }

    public override IDiscountService GetDiscount()
    {
        return new CodeDiscountService(_code);
    }
}

/// <summary>
/// Concrate Factory 2
/// </summary>
public class CountryDiscountFactory : DiscountFactory
{
    private readonly string _countryName;

    public CountryDiscountFactory(string countyName)
    {
        _countryName = countyName;
    }
    public override IDiscountService GetDiscount()
    {
        return new CountryDiscountService(_countryName);
    }
}

