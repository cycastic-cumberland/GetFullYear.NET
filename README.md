# GetFullYear.NET

An unofficial .NET client for [getfullyear.com](https://getfullyear.com) for your modern web applications.

## Features

- Written in C#
- Async support
- Support dependency injection

## Example

```csharp
public static class Program
{
    public static async Task Main(string[] args)
    {
        using var client = new GetFullYearClient();
        Console.WriteLine($"Current year: {await client.GetFullYearAsync(false)}");
        Console.WriteLine($"Current year: {await client.GetFullYearAsync(true)}"); // Only do this if you are an enterprise user
    }
}
```

## License

See [LICENSE](LICENSE.txt) for details.