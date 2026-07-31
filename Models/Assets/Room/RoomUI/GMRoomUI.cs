namespace YYModels.Models;

[YYVersion(0)]
[GMResource("roomui")]
public class GMRoomUI : GMRUIContainer
{
    /// <summary>
    /// Whether the UI is locked.
    /// </summary>
    [GameMakerProperty("locked")]
    public bool IsLocked { get; set; }

    /// <summary>
    /// The child nodes that are drawn on the view.
    /// </summary>
    [GameMakerProperty("viewspaceChildren")]
    public List<ResourceBase> ViewspaceChildren { get; set; }

    /// <summary>
    /// Whether the UI is visible.
    /// </summary>
    [GameMakerProperty("visible")]
    public bool IsVisible { get; set; }
}
