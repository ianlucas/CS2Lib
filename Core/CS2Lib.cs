using System.Reflection;
using System.Text.Json;
using CS2Lib.Models;

namespace CS2Lib;

/// <summary>
/// Main library class for interacting with CS2 items.
/// </summary>
public static class CS2Lib
{
    /// <summary>
    /// Lazy-loaded cache of all CS2 items. Deserialized once on first access.
    /// </summary>
    private static CS2Item[] Items => _items.Value;

    private static readonly Lazy<CS2Item[]> _items = new(() =>
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceName = "CS2Lib.Resources.items.json";

        using var stream = assembly.GetManifestResourceStream(resourceName)
            ?? throw new InvalidOperationException($"Could not find embedded resource: {resourceName}");

        return JsonSerializer.Deserialize(stream, CS2ItemJsonContext.Default.CS2ItemArray)
            ?? throw new InvalidOperationException("Failed to deserialize items.json");
    });

    /// <summary>
    /// Gets all CS2 items.
    /// </summary>
    /// <returns>An array of CS2Item objects.</returns>
    public static CS2Item[] GetItems()
    {
        return Items;
    }
}
