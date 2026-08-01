namespace YYModels.Models;

/// <summary>
/// The base resource for assets.
/// </summary>
[YYVersion(0)]
public class ResourceBase : IResourceBase
{
    [GameMakerIgnoreWhenWritingNull]
    public string? ResourceName { get; set; }

    // I believe version always has to exist
    public string ResourceVersion { get; set; }
    
    /// <summary>
    /// The name of the asset.
    /// </summary>
    [GameMakerProperty("name")]
    [GameMakerIgnoreWhenWritingNull]
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
    public string? LegacyResourceType => GetType().Name; // the name of the class

    /// <summary>
    /// The legacy version of the asset.
    /// </summary>
    [GameMakerProperty("resourceVersion")]
    public string? LegacyVersion { get; set; } = "2.0"; // always 2.0 in 2024+

    /// <summary>
    /// The tags that the asset has.
    /// </summary>
    [GameMakerProperty("tags")]
    [GameMakerIgnoreWhenWritingNull]
    public List<string>? Tags { get; set; }
}
