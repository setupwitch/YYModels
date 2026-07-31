namespace YYModels.Models;


public class GMResourceOrder
{
    /// <summary>
    /// The order of the folders.
    /// </summary>
    [GameMakerProperty("FolderOrderSettings")]
    public List<ResourceReferenceWithOrder> FolderOrderSettings { get; set; } = new();

    /// <summary>
    /// The order of the resources.
    /// </summary>
    [GameMakerProperty("ResourceOrderSettings")]
    public List<ResourceReferenceWithOrder> ResourceOrderSettings { get; set; } = new();
}
