using GetFullYear.NET;
using Microsoft.Extensions.DependencyInjection;

namespace GetFullYear.DependencyInjection;

/// <summary>
/// Extensions for <see cref="IGetFullYearClient"/>.
/// </summary>
public static class GetFullYearExtensions
{
    /// <summary>
    /// Add <see cref="IGetFullYearClient"/> to service collection.
    /// </summary>
    /// <param name="services">Service collection.</param>
    /// <returns>Service collection.</returns>
    public static IServiceCollection AddGetFullYearClient(this IServiceCollection services)
    {
        return services.AddSingleton<IGetFullYearClient, GetFullYearClient>();
    }
}