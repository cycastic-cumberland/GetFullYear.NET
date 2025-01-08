namespace GetFullYear.NET;

/// <summary>
/// Thrown when failed to get full year.
/// </summary>
public class GetFullYearFailedException() : Exception($"Failed to get full year for year {DateTimeOffset.Now.Year}")
{
    /// <summary>
    /// Gets the full year that was failed to get.
    /// </summary>
    public int FullYearThatWasFailedToGet { get; } = DateTimeOffset.Now.Year;
}
