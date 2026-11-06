namespace DesignPatterns.Flyweight;
public class CurrencyFormatter(string currency, string symbol)
{
    public void Print(decimal amount, string branch) => Console.WriteLine($"{branch}: {symbol}{amount:N2} {currency}");
}
public class CurrencyFormatterFactory
{
    private readonly Dictionary<string, CurrencyFormatter> _cache = [];
    public int Count => _cache.Count;
    public CurrencyFormatter Get(string currency, string symbol)
    {
        if (!_cache.TryGetValue(currency, out var formatter)) _cache[currency] = formatter = new(currency, symbol);
        return formatter;
    }
}
