/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Ian Lucas. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using SwiftlyS2.Shared.Players;

namespace CS2Lib.SwiftlyCS2.Core;

/// <summary>
/// Provides helper methods for player and team operations in CS2.
/// </summary>
public static class PlayerHelpers
{
    /// <summary>
    /// Toggles between Terrorist and Counter-Terrorist teams.
    /// </summary>
    /// <param name="team">The current team.</param>
    /// <returns>The opposite team if T or CT; otherwise, the same team (e.g., Spectator).</returns>
    public static Team ToggleTeam(Team team) =>
        team > Team.Spectator
            ? team == Team.T
                ? Team.CT
                : Team.T
            : team;

    /// <summary>
    /// Gets the full model path for a CS2 agent.
    /// </summary>
    /// <param name="model">The model name without path or extension.</param>
    /// <returns>The complete VMDL model path for the agent.</returns>
    public static string GetAgentModelPath(string model) => $"characters/models/{model}.vmdl";
}
