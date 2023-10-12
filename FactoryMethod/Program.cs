using FactoryMethod;

Console.Title = "FactoryMethod";


IEnumerable<DiscountFactory> discountFactories = new List<DiscountFactory> {
                        new CodeDiscountFactory(code:Guid.NewGuid()),
                        new CountryDiscountFactory("EGY"),
                        new CodeDiscountFactory(code:Guid.NewGuid()),
                        new CountryDiscountFactory("BEG")
                        };

foreach (var discountFactory in discountFactories)
{
    discountFactory.GetDiscount();
    Console.WriteLine(discountFactory);
}