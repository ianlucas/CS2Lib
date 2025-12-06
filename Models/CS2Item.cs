/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Ian Lucas. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System.Text.Json.Serialization;

namespace CS2Lib;

/// <summary>
/// Represents a CS2 item with all its properties.
/// </summary>
public class CS2Item
{
    [JsonPropertyName("altName")]
    public string? AltName { get; set; }

    [JsonPropertyName("base")]
    public bool? Base { get; set; }

    [JsonPropertyName("baseId")]
    public int? BaseId { get; set; }

    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("collection")]
    public string? Collection { get; set; }

    [JsonPropertyName("collectionImage")]
    public string? CollectionImage { get; set; }

    [JsonPropertyName("containerType")]
    public int? ContainerType { get; set; }

    [JsonPropertyName("contents")]
    public int[]? Contents { get; set; }

    [JsonPropertyName("def")]
    public int? Def { get; set; }

    [JsonPropertyName("free")]
    public bool? Free { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("index")]
    public int? Index { get; set; }

    [JsonPropertyName("keys")]
    public int[]? Keys { get; set; }

    [JsonPropertyName("legacy")]
    public bool? Legacy { get; set; }

    [JsonPropertyName("model")]
    public string? Model { get; set; }

    [JsonPropertyName("modelBinary")]
    public string? ModelBinary { get; set; }

    [JsonPropertyName("rarity")]
    public string? Rarity { get; set; }

    [JsonPropertyName("specials")]
    public int[]? Specials { get; set; }

    [JsonPropertyName("specialsImage")]
    public string? SpecialsImage { get; set; }

    [JsonPropertyName("statTrakless")]
    public bool? StatTrakless { get; set; }

    [JsonPropertyName("statTrakOnly")]
    public bool? StatTrakOnly { get; set; }

    [JsonPropertyName("teams")]
    public int? Teams { get; set; }

    [JsonPropertyName("textureImage")]
    public string? TextureImage { get; set; }

    [JsonPropertyName("tint")]
    public int? Tint { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = string.Empty;

    [JsonPropertyName("voFallback")]
    public bool? VoFallback { get; set; }

    [JsonPropertyName("voFemale")]
    public bool? VoFemale { get; set; }

    [JsonPropertyName("voPrefix")]
    public string? VoPrefix { get; set; }

    [JsonPropertyName("wearMax")]
    public double? WearMax { get; set; }

    [JsonPropertyName("wearMin")]
    public double? WearMin { get; set; }
}
