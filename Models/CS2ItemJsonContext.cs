using System.Text.Json.Serialization;

namespace CS2Lib.Models;

/// <summary>
/// JSON serialization context for CS2 items with source generation support.
/// This enables faster deserialization and AOT compatibility.
/// </summary>
[JsonSourceGenerationOptions(
    PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
    GenerationMode = JsonSourceGenerationMode.Metadata)]
[JsonSerializable(typeof(CS2Item[]))]
internal partial class CS2ItemJsonContext : JsonSerializerContext
{
}
