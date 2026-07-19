namespace YYModels.Models;

/// <summary>
/// The base resource for assets.
/// </summary>
/// <remarks>Version 0</remarks>
public class ResourceBase : IResourceBase
{
    public string ResourceName { get; set; }

    public string ResourceVersion { get; set; }
    
    /// <summary>
    /// The name of the asset.
    /// </summary>
    [GameMakerProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The parent of the asset.
    /// </summary>
    [GameMakerProperty("parent")]
    [GameMakerIgnoreWhenWritingNull]
    public ResourceReference<GMFolder>? Parent { get; set; }

    /// <summary>
    /// The legacy type of the asset.
    /// </summary>
    [GameMakerProperty("resourceType")]
    public string? LegacyResourceType { get; set; }

    /// <summary>
    /// The legacy version of the asset.
    /// </summary>
    [GameMakerProperty("resourceVersion")]
    public string? LegacyVersion { get; set; }

    /// <summary>
    /// The tags that the asset has.
    /// </summary>
    [GameMakerProperty("tags")]
    [GameMakerIgnoreWhenWritingNull]
    public List<string>? Tags { get; set; }
}
