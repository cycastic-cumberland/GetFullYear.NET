using System.Text.Json.Serialization;

namespace GetFullYear.NET;

[JsonSerializable(typeof(Response))]
internal partial class ResponseJsonContext : JsonSerializerContext;
