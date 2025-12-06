/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Ian Lucas. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using SwiftlyS2.Shared.SchemaDefinitions;

namespace CS2Lib.SwiftlyCS2.Extensions;

/// <summary>
/// Extension methods for CEconItemView.
/// </summary>
public static class CEconItemViewExtensions
{
    /// <summary>
    /// Gets the designer name for a CS2 item based on its definition index.
    /// </summary>
    /// <param name="item">The CEconItemView to get the designer name for.</param>
    /// <returns>The designer name prefixed with "weapon_", or null if the item is not found.</returns>
    public static string? GetDesignerName(this CEconItemView item)
    {
        var designerName = CS2Lib.GetItemByDef(item.ItemDefinitionIndex)?.Model;
        return designerName != null ? $"weapon_{designerName}" : null;
    }

    /// <summary>
    /// Checks if the item is a melee weapon based on its definition index.
    /// </summary>
    /// <param name="item">The CEconItemView to check.</param>
    /// <returns>True if the item is a melee weapon; otherwise, false.</returns>
    public static bool IsMelee(this CEconItemView item) => CS2Lib.IsMeleeDef(item.ItemDefinitionIndex);
}
