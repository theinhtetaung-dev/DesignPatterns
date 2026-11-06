using DesignPatterns.Flyweight;
var factory = new CurrencyFormatterFactory();
factory.Get("MMK", "Ks").Print(25000m, "Yangon");
factory.Get("USD", "$").Print(100m, "New York");
factory.Get("MMK", "Ks").Print(40000m, "Mandalay");
Console.WriteLine($"Shared formatters: {factory.Count}");
