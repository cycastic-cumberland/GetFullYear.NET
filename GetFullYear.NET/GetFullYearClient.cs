using System.Net.Http.Json;

namespace GetFullYear.NET;

/// <summary>
/// An implementation of <see cref="IGetFullYearClient"/>.
/// </summary>
public class GetFullYearClient : IGetFullYearClient, IDisposable
{
    private const string Url = "https://getfullyear.com/api/year";
    private readonly HttpClient _client = new();

    /// <inheritdoc />
    /// <exception cref="GetFullYearFailedException">Thrown when failed to get full year.</exception>
    public async Task<int> GetFullYearAsync(bool isEnterprise, CancellationToken cancellationToken = default)
    {
        var response = await _client.GetAsync(Url, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            throw new GetFullYearFailedException();
        }

        var responseContent = await response.Content
            .ReadFromJsonAsync(ResponseJsonContext.Default.Response, cancellationToken);
        if (responseContent == null)
        {
            throw new GetFullYearFailedException();
        }

        if (!isEnterprise)
        {
            Console.WriteLine(responseContent.SponsoredBy);
        }
        
        return responseContent.Year;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        GC.SuppressFinalize(this);
        _client.Dispose();
    }
}