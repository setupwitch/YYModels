namespace YYModels.Models;

/// <remarks>Version 0</remarks>
public class GMRUIFolder : GMRUIContainer
{
    /// <summary>
    /// Whether the folder is locked.
    /// </summary>
    [GameMakerProperty("locked")]
    public bool IsLocked { get; set; }

    /// <summary>
    /// Whether the folder is visible.
    /// </summary>
    [GameMakerProperty("visible")]
    public bool IsVisible { get; set; }
}