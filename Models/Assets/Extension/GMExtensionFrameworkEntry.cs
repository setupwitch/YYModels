namespace YYModels.Models;

/// <remarks>Version 0</remarks>
public class GMExtensionFrameworkEntry : ResourceBase
{
    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("embed")]
    public int Embed { get; set; }

    /// <summary>
    /// Unknown.
    /// </summary>
    [GameMakerProperty("weakReference")]
    public bool WeakReference { get; set; }
}