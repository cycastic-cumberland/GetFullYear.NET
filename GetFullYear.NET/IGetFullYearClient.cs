namespace GetFullYear.NET;

/// <summary>
/// Represent a client for getfullyear.com.
/// </summary>
public interface IGetFullYearClient
{
    /// <summary>
    /// Asynchronously get full year.
    /// </summary>
    /// <param name="isEnterprise">Whether you are an enterprise user or not.</param>
    /// <param name="cancellationToken">Cancellation token.</param>
    /// <returns>Full year.</returns>
    Task<int> GetFullYearAsync(bool isEnterprise, CancellationToken cancellationToken = default);
}