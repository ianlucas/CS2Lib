/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Ian Lucas. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using SwiftlyS2.Shared.SchemaDefinitions;

namespace CS2Lib.SwiftlyCS2.Extensions;

/// <summary>
/// Extension methods for CBasePlayerWeapon.
/// </summary>
public static class CBasePlayerWeaponExtensions
{
    /// <summary>
    /// Gets the designer name for a player weapon, normalizing melee weapons to "weapon_knife".
    /// </summary>
    /// <param name="weapon">The CBasePlayerWeapon to get the designer name for.</param>
    /// <returns>The designer name, with melee weapons normalized to "weapon_knife".</returns>
    public static string GetDesignerName(this CBasePlayerWeapon weapon)
    {
        var designerName = weapon.AttributeManager.Item.GetDesignerName() ?? weapon.DesignerName;
        return CS2Items.IsMeleeDesignerName(designerName) ? "weapon_knife" : designerName;
    }
}
