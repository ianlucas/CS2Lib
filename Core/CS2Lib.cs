using System.Collections.Concurrent;
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

    /// <summary>
    /// Lazy-loaded dictionary for O(1) item lookups by ID.
    /// </summary>
    private static ConcurrentDictionary<int, CS2Item> ItemsById => _itemsById.Value;

    private static readonly Lazy<CS2Item[]> _items = new(() =>
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceName = "CS2Lib.Resources.items.json";

        using var stream = assembly.GetManifestResourceStream(resourceName)
            ?? throw new InvalidOperationException($"Could not find embedded resource: {resourceName}");

        return JsonSerializer.Deserialize(stream, CS2ItemJsonContext.Default.CS2ItemArray)
            ?? throw new InvalidOperationException("Failed to deserialize items.json");
    });

    private static readonly Lazy<ConcurrentDictionary<int, CS2Item>> _itemsById = new(() =>
    {
        var items = Items;
        var dictionary = new ConcurrentDictionary<int, CS2Item>(
            Environment.ProcessorCount * 2,
            items.Length);

        foreach (var item in items)
            dictionary.TryAdd(item.Id, item);

        return dictionary;
    });

    /// <summary>
    /// Gets all CS2 items.
    /// </summary>
    /// <returns>An array of CS2Item objects.</returns>
    public static CS2Item[] GetItems()
    {
        return Items;
    }

    /// <summary>
    /// Gets a CS2 item by its unique ID.
    /// </summary>
    /// <param name="id">The unique ID of the item.</param>
    /// <returns>The CS2Item if found; otherwise, null.</returns>
    public static CS2Item? GetItemById(int id)
    {
        return ItemsById.TryGetValue(id, out var item) ? item : null;
    }
}
