namespace YYModels.Models;

[YYVersion(1)]
[GMResource("scripts")]
public class GMScript : ResourceBase
{
    /// <summary>
    /// Whether the script is a compatiblity script.
    /// </summary>
    [GameMakerProperty("isCompatibility")]
    public bool IsCompatibility { get; set; }

    /// <summary>
    /// Whether the script has "drag and drop" mode enabled.
    /// </summary>
    [GameMakerProperty("isDnD")]
    public bool IsDragAndDrop { get; set; }
}