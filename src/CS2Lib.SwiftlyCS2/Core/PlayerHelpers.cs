/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Ian Lucas. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using SwiftlyS2.Shared.Players;

namespace CS2Lib.SwiftlyCS2.Core;

public static class PlayerHelpers
{
    public static Team ToggleTeam(Team team) =>
        team > Team.Spectator
            ? team == Team.T
                ? Team.CT
                : Team.T
            : team;

    public static string GetAgentModelPath(string model) => $"characters/models/{model}.vmdl";
}
