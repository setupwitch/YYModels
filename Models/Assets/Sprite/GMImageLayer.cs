namespace YYModels.Models;

/// <summary>
/// An image layer for a sprite.
/// </summary>
/// <remarks>Version 0</remarks>
[GameMakerDerivedType(typeof(GMImageLayer), nameof(GMImageLayer))]
[GameMakerDerivedType(typeof(GMImageFolderLayer), nameof(GMImageFolderLayer))]
public class GMImageLayer : ResourceBase
{
    /// <summary>
    /// The blend mode of the layer, see <see cref="SpriteLayerBlendType"/>.
    /// </summary>
    [GameMakerProperty("blendMode")]
    public SpriteLayerBlendType BlendMode { get; set; }

    /// <summary>
    /// The display name of the layer.
    /// </summary>
    [GameMakerProperty("displayName")]
    public string LayerName { get; set; }

    /// <summary>
    /// Whether the layer is locked.
    /// </summary>
    [GameMakerProperty("isLocked")]
    public bool IsLocked { get; set; }

    /// <summary>
    /// The opacity of the layer.
    /// </summary>
    [GameMakerProperty("opacity")]
    public float Opacity { get; set; }

    /// <summary>
    /// Whether the layer is visible.
    /// </summary>
    [GameMakerProperty("visible")]
    public bool IsVisible { get; set; }
}

/// <summary>
/// A folder that holds sprite layers.
/// </summary>
/// <remarks>Version 0</remarks>
public class GMImageFolderLayer : GMImageLayer
{
    [GameMakerProperty("layers")]
    public List<GMImageLayer> Layers { get; set; }
}