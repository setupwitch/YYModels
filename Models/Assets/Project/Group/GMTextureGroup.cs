namespace YYModels.Models;

[YYVersion(0)]
public class GMTextureGroup : GMBaseGroup
{
    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("autocrop")]
    public bool DoAutoCrop { get; set; }

    /// <summary>
    /// The size of the border.
    /// </summary>
    [GameMakerProperty("border")]
    public int BorderSize { get; set; }

    /// <summary>
    /// The type of compression that the texture group uses.
    /// </summary>
    [GameMakerProperty("compressFormat")]
    public string CompressionType { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("customOptions")]
    public string CustomOptions { get; set; }

    /// <summary>
    /// The directory that the texture group is exported to.
    /// </summary>
    [GameMakerProperty("directory")]
    public string ExportDirectory { get; set; }

    /// <summary>
    /// The parent of the texture group.
    /// </summary>
    [GameMakerProperty("groupParent")]
    public GMTextureGroup GroupParent { get; set; }

    /// <summary>
    /// Whether scaling is allowed.
    /// </summary>
    [GameMakerProperty("isScaled")]
    public bool AllowScaling { get; set; }

    /// <summary>
    /// The way the texture group loads.
    /// </summary>
    [GameMakerProperty("loadType")]
    public string LoadType { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("mipsToGenerate")]
    public int MipMapsToGenerate { get; set; }
}