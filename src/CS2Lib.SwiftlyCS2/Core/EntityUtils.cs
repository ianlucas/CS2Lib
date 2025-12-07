/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Ian Lucas. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace CS2Lib.SwiftlyCS2.Core;

public static class EntityUtils
{
    public const byte None = 0;
    public const byte Spectator = 1;
    public const byte T = 2;
    public const byte CT = 3;

    public static byte ToggleTeam(byte team) =>
        team > Spectator
            ? team == T
                ? CT
                : T
            : team;

    public static string GetAgentModelPath(string model) => $"characters/models/{model}.vmdl";
}
