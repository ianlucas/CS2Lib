using System.Reflection;
using System.Text.Json;

namespace CS2Lib;

/// <summary>
/// Provides access to CS2 item data.
/// </summary>
public static class CS2Items
{
    private static readonly Lazy<CS2Item[]> _items = new(LoadItems);

    /// <summary>
    /// Gets all CS2 items from the embedded items.json file.
    /// </summary>
    /// <returns>An array of CS2Item objects.</returns>
    public static CS2Item[] GetItems()
    {
        return _items.Value;
    }

    private static CS2Item[] LoadItems()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceName = "CS2Lib.items.json";

        using var stream = assembly.GetManifestResourceStream(resourceName)
            ?? throw new InvalidOperationException($"Could not find embedded resource: {resourceName}");

        var items = JsonSerializer.Deserialize<CS2Item[]>(stream)
            ?? throw new InvalidOperationException("Failed to deserialize items.json");

        return items;
    }
}
